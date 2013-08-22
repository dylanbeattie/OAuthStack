using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using DotNetOpenAuth.OAuth2;
using OAuthStack.Common.ServiceModel;
using OAuthStack.Common.Services;
using OAuthStack.FakeServices;
using ServiceStack.ServiceClient.Web;
using ServiceStack.Text;

namespace OAuthStack.DemoClient {
    public partial class Form1 : Form {

        IAuthorizationState authState;
        IUserStore userStore;

        public Form1() {
            InitializeComponent();
            userStore = new FakeUserStore();
        }

        public void UpdateFields() {
            accessTokenTextBox.Text = authState.AccessToken;
            refreshTokenTextBox.Text = authState.RefreshToken;
            tokenExpiryTextBox.Text = authState.AccessTokenExpirationUtc.Value.ToString("O");
            refreshTokenButton.Enabled = true;
            getResourceButton.Enabled = true;
        }

        protected void exchangeCredentialsButton_Click(object sender, EventArgs e) {
            try {
                var client = CreateOAuth2Client();
                var scopes = (scopesTextBox.Text ?? String.Empty).Split(' ');
                authState = client.ExchangeUserCredentialForToken(usernameTextBox.Text, passwordTextBox.Text, scopes);
                UpdateFields();
            } catch (Exception ex) {
                for (; ex != null; ex = ex.InnerException) {
                    outputTextBox.Text += ex.Message + Environment.NewLine;
                }
            }

        }
        private void Form1_Load(object sender, EventArgs e) {
            oauth2ClientIdTextBox.Text = FakeOAuth2ClientStore.CLIENT_IDENTIFIER;
            oauth2ClientSecretTextBox.Text = FakeOAuth2ClientStore.CLIENT_SECRET;
        }

        private WebServerClient CreateOAuth2Client() {
            var serverDescription = new AuthorizationServerDescription {
                TokenEndpoint = new Uri(tokenEndpointTextBox.Text)
            };
            var client = new WebServerClient(serverDescription, oauth2ClientIdTextBox.Text, oauth2ClientSecretTextBox.Text);
            return (client);
        }

        private void refreshTokenButton_Click(object sender, EventArgs e) {
            var client = CreateOAuth2Client();
            if (client.RefreshAuthorization(authState)) UpdateFields();
        }

        private void usernameLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            var user = userStore.GetUser(((LinkLabel)sender).Text);
            usernameTextBox.Text = user.Username;
            passwordTextBox.Text = user.Password;
        }

        private void getResourceButton_Click(object sender, EventArgs e) {
            var sb = new StringBuilder();

            // Create the ServiceStack API client and the request DTO
            var apiClient = new JsonServiceClient(resourceUriTextBox.Text);
            var apiRequestDto = new Users { Username = usernameTextBox.Text };

            // Wire up the ServiceStack client filter so that DotNetOpenAuth can 
            // add the authorization header before the request is sent
            // to the API server
            apiClient.LocalHttpWebRequestFilter = request => {
                ClientBase.AuthorizeRequest(request, accessTokenTextBox.Text);
                LogStuff(request, sb);
            };
            // This filter is used only for logging the response output. The code will work without it.
            apiClient.LocalHttpWebResponseFilter += response => LogStuff(response, sb);

            try {
                // Send the API request and dump the response to our output TextBox
                var response = apiClient.Get(apiRequestDto);
                sb.AppendLine(String.Empty.PadRight(TRIM_HEADER_AT, '='));
                sb.AppendLine(String.Format("Full Name: {0} {1}", response.Forenames, response.Surname));
                sb.AppendLine(String.Format("E-mail: {0}", response.Email));
            } catch (WebServiceException ex) {
                sb.AppendLine(ex.Dump());
                sb.AppendLine(ex.ResponseBody.Replace(" at ", Environment.NewLine + "   at "));
            } catch (Exception ex) {
                sb.AppendLine(ex.Message);
            }
            outputTextBox.Text = sb.ToString();
        }

        private const int TRIM_HEADER_AT = 32;
        private void LogStuff(HttpWebRequest request, StringBuilder sb) {
            sb.Append(request.Method);
            sb.Append(" ");
            sb.AppendLine(request.RequestUri.PathAndQuery);
            foreach (var header in request.Headers.AllKeys) {
                sb.AppendLine(String.Format("  {0}: {1}", header, request.Headers[header].Length > TRIM_HEADER_AT ? request.Headers[header].Substring(0, TRIM_HEADER_AT) + "..." : request.Headers[header]));
            }
        }

        private void LogStuff(HttpWebResponse rsp, StringBuilder sb) {
            sb.AppendLine(String.Empty.PadLeft(32, '='));
            sb.AppendLine(rsp.StatusCode + " " + rsp.StatusDescription);
            foreach (var header in rsp.Headers.AllKeys) {
                sb.AppendLine(String.Format("  {0}: {1}", header, rsp.Headers[header].Length > TRIM_HEADER_AT ? rsp.Headers[header].Substring(0, TRIM_HEADER_AT) + "..." : rsp.Headers[header]));
            }
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e) {
            getResourceButton.Text = String.Format("GET /users/{0}", usernameTextBox.Text);
        }
    }
}
