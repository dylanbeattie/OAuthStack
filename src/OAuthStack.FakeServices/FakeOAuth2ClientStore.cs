using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DotNetOpenAuth.OAuth2;
using OAuthStack.Common.Services;

namespace OAuthStack.FakeServices {
    /// <summary>A fake implementation of <see cref="IOAuth2ClientStore"/> that returns a single fake client</summary>
    public class FakeOAuth2ClientStore : IOAuth2ClientStore {
        public const string CLIENT_IDENTIFIER = "fake_client";
        public const string CLIENT_SECRET = "fake_secret";
        private static readonly FakeOAuth2Client FakeClient = new FakeOAuth2Client(CLIENT_IDENTIFIER, CLIENT_SECRET) {
            ClientName = "OAuthStack Demo - Fake Client"
        };

        public IClientDescription GetClient(string clientIdentifier) {
            if (clientIdentifier == CLIENT_IDENTIFIER) return (FakeClient);
            return (null);
        }
    }
}
