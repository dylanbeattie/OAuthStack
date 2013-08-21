using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DotNetOpenAuth.OAuth2;
using OAuthStack.FakeServices;

namespace OAuthStack.DemoClient {
    public partial class Form1 : Form {

        IAuthorizationState authState;

        public Form1() {
            InitializeComponent();
        }

        public void UpdateFields() {
            accessTokenTextBox.Text = authState.AccessToken;
            refreshTokenTextBox.Text = authState.RefreshToken;
            tokenExpiryTextBox.Text = authState.AccessTokenExpirationUtc.Value.ToString("O");
        }

        protected void exchangeCredentialsButton_Click(object sender, EventArgs e) {
            try {
                var serverDescription = new AuthorizationServerDescription {
                    TokenEndpoint = new Uri(tokenEndpointTextBox.Text)
                };
                var scopes = (scopesTextBox.Text ?? String.Empty).Split(' ');
                var client = new WebServerClient(serverDescription, oauth2ClientIdTextBox.Text, oauth2ClientSecretTextBox.Text);
                authState = client.ExchangeUserCredentialForToken(usernameTextBox.Text, passwordTextBox.Text, scopes);
                UpdateFields();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form1_Load(object sender, EventArgs e) {
            oauth2ClientIdTextBox.Text = FakeOAuth2ClientStore.CLIENT_IDENTIFIER;
            oauth2ClientSecretTextBox.Text = FakeOAuth2ClientStore.CLIENT_SECRET;
        }
    }
}
