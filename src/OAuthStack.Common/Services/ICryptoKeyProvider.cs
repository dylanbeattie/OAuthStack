using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;


namespace OAuthStack.Common.Services {
    /// <summary>Provides access to the public and private keys used to create and verify OAuth2 tokens.</summary>
    public interface ICryptoKeyProvider {
        /// <summary>The public key used by the auth server to sign access tokens.</summary>
        RSACryptoServiceProvider RestServerPublicKey { get; }

        RSACryptoServiceProvider AuthServerPublicKey { get; }

        RSACryptoServiceProvider RestServerPrivateKey { get; }

        RSACryptoServiceProvider AuthServerPrivateKey { get; }
    }
}
