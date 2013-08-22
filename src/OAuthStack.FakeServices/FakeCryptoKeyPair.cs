using System.Security.Cryptography;
using OAuthStack.Common.Services;

namespace OAuthStack.FakeServices {
    /// <summary>Provides a FAKE implementation using hard-coded RSA crypto keys. Don't do this in production. Really.</summary>
    public class CryptoKeyPair : ICryptoKeyPair {
        private readonly RSAParameters publicKey;
        private readonly RSAParameters secretKey;

        public CryptoKeyPair(RSAParameters publicKey, RSAParameters secretKey) {
            this.publicKey = publicKey;
            this.secretKey = secretKey;
            publicKeyProvider = new RSACryptoServiceProvider();
            secretKeyProvider = new RSACryptoServiceProvider();
            publicKeyProvider.ImportParameters(publicKey);
            secretKeyProvider.ImportParameters(secretKey);
        }

        private readonly RSACryptoServiceProvider publicKeyProvider;
        private readonly RSACryptoServiceProvider secretKeyProvider;

        public RSACryptoServiceProvider PublicSigningKey {
            get { return (publicKeyProvider); }
        }

        public RSACryptoServiceProvider PrivateEncryptionKey {
            get { return (secretKeyProvider); }
        }
    }
}
