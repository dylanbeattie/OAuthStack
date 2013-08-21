using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            var authorizationServerDescription = new AuthorizationServerDescription() {
                TokenEndpoint = new Uri(tokenEndpointTextBox.Text)
            };

            var oauth2client = new UserAgentClient(authorizationServerDescription, oauth2ClientIdTextBox.Text, oauth2ClientSecretTextBox.Text);

            var apiClient = new JsonServiceClient(resourceUriTextBox.Text);
            var request = new Users { Username = usernameTextBox.Text };
            apiClient.LocalHttpWebRequestFilter = req => {
                ClientBase.AuthorizeRequest(req, accessTokenTextBox.Text);
                sb.Append(req.Method);
                sb.Append(" ");
                sb.AppendLine(req.RequestUri.PathAndQuery);
                foreach (var header in req.Headers.AllKeys) {
                    sb.AppendLine(String.Format("  {0}: {1}", header, req.Headers[header].Length > 20 ? req.Headers[header].Substring(20) + "..." : req.Headers[header]));
                }
            };
            apiClient.OnAuthenticationRequired += webRequest => {
                sb.AppendLine(String.Empty.PadLeft(32, '='));
            };
            apiClient.LocalHttpWebResponseFilter += rsp => {
                sb.AppendLine(String.Empty.PadLeft(32, '='));
                sb.AppendLine(rsp.StatusCode + " " + rsp.StatusDescription);
                foreach (var header in rsp.Headers.AllKeys) {
                    sb.AppendLine(String.Format("  {0}: {1}", header, rsp.Headers[header]));
                }
                //sb.AppendLine(new StreamReader(rsp.GetResponseStream()).ReadToEnd());
            };
            try {
                var response = apiClient.Get(request);
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

        private void outputTextBox_TextChanged(object sender, EventArgs e) {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e) {
            getResourceButton.Text = String.Format("GET /users/{0}", usernameTextBox.Text);
        }
    }
}
