namespace OAuthStack.DemoClient {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tokenEndpointLabel = new System.Windows.Forms.Label();
            this.tokenEndpointTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.oauth2ClientIdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.oauth2ClientSecretTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.exchangeCredentialsButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.scopesTextBox = new System.Windows.Forms.TextBox();
            this.accessTokenLabel = new System.Windows.Forms.Label();
            this.accessTokenTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.refreshTokenTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tokenExpiryTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tokenEndpointLabel
            // 
            this.tokenEndpointLabel.AutoSize = true;
            this.tokenEndpointLabel.Location = new System.Drawing.Point(12, 15);
            this.tokenEndpointLabel.Name = "tokenEndpointLabel";
            this.tokenEndpointLabel.Size = new System.Drawing.Size(125, 13);
            this.tokenEndpointLabel.TabIndex = 0;
            this.tokenEndpointLabel.Text = "OAuth2 Token Endpoint:";
            // 
            // tokenEndpointTextBox
            // 
            this.tokenEndpointTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tokenEndpointTextBox.Location = new System.Drawing.Point(159, 12);
            this.tokenEndpointTextBox.Name = "tokenEndpointTextBox";
            this.tokenEndpointTextBox.Size = new System.Drawing.Size(319, 20);
            this.tokenEndpointTextBox.TabIndex = 1;
            this.tokenEndpointTextBox.Text = "http://localhost:50001/oauth2/token";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "OAuth2 Client ID:";
            // 
            // oauth2ClientIdTextBox
            // 
            this.oauth2ClientIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oauth2ClientIdTextBox.Location = new System.Drawing.Point(159, 38);
            this.oauth2ClientIdTextBox.Name = "oauth2ClientIdTextBox";
            this.oauth2ClientIdTextBox.Size = new System.Drawing.Size(319, 20);
            this.oauth2ClientIdTextBox.TabIndex = 1;
            this.oauth2ClientIdTextBox.Text = "fake_client_id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "OAuth2 Client Secret:";
            // 
            // oauth2ClientSecretTextBox
            // 
            this.oauth2ClientSecretTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oauth2ClientSecretTextBox.Location = new System.Drawing.Point(159, 64);
            this.oauth2ClientSecretTextBox.Name = "oauth2ClientSecretTextBox";
            this.oauth2ClientSecretTextBox.Size = new System.Drawing.Size(319, 20);
            this.oauth2ClientSecretTextBox.TabIndex = 1;
            this.oauth2ClientSecretTextBox.Text = "fake_client_secret";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(12, 93);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(141, 13);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Resource Owner Username:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTextBox.Location = new System.Drawing.Point(159, 90);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(319, 20);
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.Text = "example_username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(12, 119);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(139, 13);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "Resource Owner Password:";
            this.passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.Location = new System.Drawing.Point(159, 116);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(319, 20);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.Text = "example_password";
            // 
            // exchangeCredentialsButton
            // 
            this.exchangeCredentialsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exchangeCredentialsButton.Location = new System.Drawing.Point(159, 168);
            this.exchangeCredentialsButton.Name = "exchangeCredentialsButton";
            this.exchangeCredentialsButton.Size = new System.Drawing.Size(319, 23);
            this.exchangeCredentialsButton.TabIndex = 2;
            this.exchangeCredentialsButton.Text = "Exchange Credentials for Access Token";
            this.exchangeCredentialsButton.UseVisualStyleBackColor = true;
            this.exchangeCredentialsButton.Click += new System.EventHandler(this.exchangeCredentialsButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "OAuth2 Scope(s):";
            this.label3.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // scopesTextBox
            // 
            this.scopesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scopesTextBox.Location = new System.Drawing.Point(159, 142);
            this.scopesTextBox.Name = "scopesTextBox";
            this.scopesTextBox.Size = new System.Drawing.Size(319, 20);
            this.scopesTextBox.TabIndex = 1;
            this.scopesTextBox.Text = "scope1 scope2 scope3";
            // 
            // accessTokenLabel
            // 
            this.accessTokenLabel.AutoSize = true;
            this.accessTokenLabel.Location = new System.Drawing.Point(12, 200);
            this.accessTokenLabel.Name = "accessTokenLabel";
            this.accessTokenLabel.Size = new System.Drawing.Size(118, 13);
            this.accessTokenLabel.TabIndex = 0;
            this.accessTokenLabel.Text = "OAuth2 Access Token:";
            this.accessTokenLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // accessTokenTextBox
            // 
            this.accessTokenTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accessTokenTextBox.Location = new System.Drawing.Point(159, 197);
            this.accessTokenTextBox.Name = "accessTokenTextBox";
            this.accessTokenTextBox.Size = new System.Drawing.Size(319, 20);
            this.accessTokenTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "OAuth2 Refresh Token:";
            this.label4.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // refreshTokenTextBox
            // 
            this.refreshTokenTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshTokenTextBox.Location = new System.Drawing.Point(159, 223);
            this.refreshTokenTextBox.Name = "refreshTokenTextBox";
            this.refreshTokenTextBox.Size = new System.Drawing.Size(319, 20);
            this.refreshTokenTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "OAuth2 Token Expiry:";
            this.label5.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // tokenExpiryTextBox
            // 
            this.tokenExpiryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tokenExpiryTextBox.Location = new System.Drawing.Point(159, 249);
            this.tokenExpiryTextBox.Name = "tokenExpiryTextBox";
            this.tokenExpiryTextBox.Size = new System.Drawing.Size(319, 20);
            this.tokenExpiryTextBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 510);
            this.Controls.Add(this.exchangeCredentialsButton);
            this.Controls.Add(this.tokenExpiryTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.refreshTokenTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.accessTokenTextBox);
            this.Controls.Add(this.accessTokenLabel);
            this.Controls.Add(this.scopesTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.oauth2ClientSecretTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oauth2ClientIdTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tokenEndpointTextBox);
            this.Controls.Add(this.tokenEndpointLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tokenEndpointLabel;
        private System.Windows.Forms.TextBox tokenEndpointTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox oauth2ClientIdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox oauth2ClientSecretTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button exchangeCredentialsButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox scopesTextBox;
        private System.Windows.Forms.Label accessTokenLabel;
        private System.Windows.Forms.TextBox accessTokenTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox refreshTokenTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tokenExpiryTextBox;
    }
}

