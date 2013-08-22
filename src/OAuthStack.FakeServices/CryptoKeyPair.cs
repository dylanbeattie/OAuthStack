using System;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Web.Hosting;
using OAuthStack.Common.Services;

namespace OAuthStack.FakeServices {
    /// <summary>Provides a FAKE implementation using hard-coded RSA crypto keys. Don't do this in production. Really.</summary>
    public class CryptoKeyPair : ICryptoKeyPair {

        public static ICryptoKeyPair LoadCertificate(string certificateFilePath, string certificatePassword) {
            var fileInfo = new FileInfo(certificateFilePath);
            return (new CryptoKeyPair(fileInfo, certificatePassword));
        }

        public CryptoKeyPair(FileInfo certificateFileInfo, string certificatePassword) {
            var cert = new X509Certificate2(certificateFileInfo.FullName, certificatePassword);
            this.publicKeyProvider = cert.PublicKey.Key as RSACryptoServiceProvider;
            this.secretKeyProvider = cert.PrivateKey as RSACryptoServiceProvider;
        }

        public CryptoKeyPair(RSAParameters publicKey, RSAParameters secretKey) {
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
