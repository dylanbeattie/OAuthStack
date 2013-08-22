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
            this.refreshTokenButton = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.resourceUriTextBox = new System.Windows.Forms.TextBox();
            this.evhLinkLabel = new System.Windows.Forms.LinkLabel();
            this.satchLinkLabel = new System.Windows.Forms.LinkLabel();
            this.knopflerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.getResourceButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tokenEndpointLabel
            // 
            this.tokenEndpointLabel.AutoSize = true;
            this.tokenEndpointLabel.Location = new System.Drawing.Point(6, 25);
            this.tokenEndpointLabel.Name = "tokenEndpointLabel";
            this.tokenEndpointLabel.Size = new System.Drawing.Size(125, 13);
            this.tokenEndpointLabel.TabIndex = 0;
            this.tokenEndpointLabel.Text = "OAuth2 Token Endpoint:";
            // 
            // tokenEndpointTextBox
            // 
            this.tokenEndpointTextBox.Location = new System.Drawing.Point(153, 22);
            this.tokenEndpointTextBox.Name = "tokenEndpointTextBox";
            this.tokenEndpointTextBox.Size = new System.Drawing.Size(255, 20);
            this.tokenEndpointTextBox.TabIndex = 1;
            this.tokenEndpointTextBox.Text = "http://localhost:50001/oauth2/token";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "OAuth2 Client ID:";
            // 
            // oauth2ClientIdTextBox
            // 
            this.oauth2ClientIdTextBox.Location = new System.Drawing.Point(153, 48);
            this.oauth2ClientIdTextBox.Name = "oauth2ClientIdTextBox";
            this.oauth2ClientIdTextBox.Size = new System.Drawing.Size(255, 20);
            this.oauth2ClientIdTextBox.TabIndex = 1;
            this.oauth2ClientIdTextBox.Text = "fake_client_id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "OAuth2 Client Secret:";
            // 
            // oauth2ClientSecretTextBox
            // 
            this.oauth2ClientSecretTextBox.Location = new System.Drawing.Point(153, 74);
            this.oauth2ClientSecretTextBox.Name = "oauth2ClientSecretTextBox";
            this.oauth2ClientSecretTextBox.Size = new System.Drawing.Size(255, 20);
            this.oauth2ClientSecretTextBox.TabIndex = 1;
            this.oauth2ClientSecretTextBox.Text = "fake_client_secret";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(6, 22);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(141, 13);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Resource Owner Username:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(153, 19);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(255, 20);
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.Text = "example_username";
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(6, 48);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(139, 13);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "Resource Owner Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(153, 45);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(255, 20);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.Text = "example_password";
            // 
            // exchangeCredentialsButton
            // 
            this.exchangeCredentialsButton.Location = new System.Drawing.Point(159, 441);
            this.exchangeCredentialsButton.Name = "exchangeCredentialsButton";
            this.exchangeCredentialsButton.Size = new System.Drawing.Size(267, 23);
            this.exchangeCredentialsButton.TabIndex = 2;
            this.exchangeCredentialsButton.Text = "Exchange Credentials for Access Token";
            this.exchangeCredentialsButton.UseVisualStyleBackColor = true;
            this.exchangeCredentialsButton.Click += new System.EventHandler(this.exchangeCredentialsButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "OAuth2 Scope(s):";
            // 
            // scopesTextBox
            // 
            this.scopesTextBox.Location = new System.Drawing.Point(159, 415);
            this.scopesTextBox.Name = "scopesTextBox";
            this.scopesTextBox.Size = new System.Drawing.Size(267, 20);
            this.scopesTextBox.TabIndex = 1;
            this.scopesTextBox.Text = "user_info some_other_scope try_changing_these";
            // 
            // accessTokenLabel
            // 
            this.accessTokenLabel.AutoSize = true;
            this.accessTokenLabel.Location = new System.Drawing.Point(12, 473);
            this.accessTokenLabel.Name = "accessTokenLabel";
            this.accessTokenLabel.Size = new System.Drawing.Size(118, 13);
            this.accessTokenLabel.TabIndex = 0;
            this.accessTokenLabel.Text = "OAuth2 Access Token:";
            // 
            // accessTokenTextBox
            // 
            this.accessTokenTextBox.Location = new System.Drawing.Point(159, 470);
            this.accessTokenTextBox.Name = "accessTokenTextBox";
            this.accessTokenTextBox.Size = new System.Drawing.Size(267, 20);
            this.accessTokenTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 499);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "OAuth2 Refresh Token:";
            // 
            // refreshTokenTextBox
            // 
            this.refreshTokenTextBox.Location = new System.Drawing.Point(159, 496);
            this.refreshTokenTextBox.Name = "refreshTokenTextBox";
            this.refreshTokenTextBox.Size = new System.Drawing.Size(267, 20);
            this.refreshTokenTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 525);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "OAuth2 Token Expiry:";
            // 
            // tokenExpiryTextBox
            // 
            this.tokenExpiryTextBox.Location = new System.Drawing.Point(159, 522);
            this.tokenExpiryTextBox.Name = "tokenExpiryTextBox";
            this.tokenExpiryTextBox.Size = new System.Drawing.Size(267, 20);
            this.tokenExpiryTextBox.TabIndex = 1;
            // 
            // refreshTokenButton
            // 
            this.refreshTokenButton.Enabled = false;
            this.refreshTokenButton.Location = new System.Drawing.Point(159, 548);
            this.refreshTokenButton.Name = "refreshTokenButton";
            this.refreshTokenButton.Size = new System.Drawing.Size(267, 23);
            this.refreshTokenButton.TabIndex = 2;
            this.refreshTokenButton.Text = "Refresh Access Token";
            this.refreshTokenButton.UseVisualStyleBackColor = true;
            this.refreshTokenButton.Click += new System.EventHandler(this.refreshTokenButton_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputTextBox.Location = new System.Drawing.Point(432, 12);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(433, 654);
            this.outputTextBox.TabIndex = 3;
            this.outputTextBox.TextChanged += new System.EventHandler(this.outputTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 580);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "User info API root URI:";
            // 
            // resourceUriTextBox
            // 
            this.resourceUriTextBox.Location = new System.Drawing.Point(159, 577);
            this.resourceUriTextBox.Name = "resourceUriTextBox";
            this.resourceUriTextBox.Size = new System.Drawing.Size(267, 20);
            this.resourceUriTextBox.TabIndex = 1;
            this.resourceUriTextBox.Text = "http://localhost:50002/";
            // 
            // evhLinkLabel
            // 
            this.evhLinkLabel.AutoSize = true;
            this.evhLinkLabel.Location = new System.Drawing.Point(150, 74);
            this.evhLinkLabel.Name = "evhLinkLabel";
            this.evhLinkLabel.Size = new System.Drawing.Size(25, 13);
            this.evhLinkLabel.TabIndex = 5;
            this.evhLinkLabel.TabStop = true;
            this.evhLinkLabel.Text = "evh";
            this.evhLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.usernameLinkLabel_LinkClicked);
            // 
            // satchLinkLabel
            // 
            this.satchLinkLabel.AutoSize = true;
            this.satchLinkLabel.Location = new System.Drawing.Point(181, 74);
            this.satchLinkLabel.Name = "satchLinkLabel";
            this.satchLinkLabel.Size = new System.Drawing.Size(33, 13);
            this.satchLinkLabel.TabIndex = 6;
            this.satchLinkLabel.TabStop = true;
            this.satchLinkLabel.Text = "satch";
            this.satchLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.usernameLinkLabel_LinkClicked);
            // 
            // knopflerLinkLabel
            // 
            this.knopflerLinkLabel.AutoSize = true;
            this.knopflerLinkLabel.Location = new System.Drawing.Point(220, 74);
            this.knopflerLinkLabel.Name = "knopflerLinkLabel";
            this.knopflerLinkLabel.Size = new System.Drawing.Size(45, 13);
            this.knopflerLinkLabel.TabIndex = 7;
            this.knopflerLinkLabel.TabStop = true;
            this.knopflerLinkLabel.Text = "knopfler";
            this.knopflerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.usernameLinkLabel_LinkClicked);
            // 
            // getResourceButton
            // 
            this.getResourceButton.Location = new System.Drawing.Point(159, 603);
            this.getResourceButton.Name = "getResourceButton";
            this.getResourceButton.Size = new System.Drawing.Size(267, 23);
            this.getResourceButton.TabIndex = 2;
            this.getResourceButton.Text = "GET /users/{username}";
            this.getResourceButton.UseVisualStyleBackColor = true;
            this.getResourceButton.Click += new System.EventHandler(this.getResourceButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sample Resource Owners:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.tokenEndpointLabel);
            this.groupBox1.Controls.Add(this.tokenEndpointTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.oauth2ClientIdTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.oauth2ClientSecretTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 160);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OAuth2 Authorization Server Details";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(153, 101);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(254, 53);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Remember, the client is the application - NOT the person using it. You\'ll typical" +
    "ly need to register your app with some OAuth2 provider to obtain the client ID a" +
    "nd client secret used here.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.usernameLabel);
            this.groupBox2.Controls.Add(this.usernameTextBox);
            this.groupBox2.Controls.Add(this.knopflerLinkLabel);
            this.groupBox2.Controls.Add(this.passwordLabel);
            this.groupBox2.Controls.Add(this.satchLinkLabel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.evhLinkLabel);
            this.groupBox2.Controls.Add(this.passwordTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 97);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resource Owner Credentials";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 678);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.getResourceButton);
            this.Controls.Add(this.refreshTokenButton);
            this.Controls.Add(this.exchangeCredentialsButton);
            this.Controls.Add(this.resourceUriTextBox);
            this.Controls.Add(this.tokenExpiryTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.refreshTokenTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.accessTokenTextBox);
            this.Controls.Add(this.accessTokenLabel);
            this.Controls.Add(this.scopesTextBox);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Button refreshTokenButton;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox resourceUriTextBox;
        private System.Windows.Forms.LinkLabel evhLinkLabel;
        private System.Windows.Forms.LinkLabel satchLinkLabel;
        private System.Windows.Forms.LinkLabel knopflerLinkLabel;
        private System.Windows.Forms.Button getResourceButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

