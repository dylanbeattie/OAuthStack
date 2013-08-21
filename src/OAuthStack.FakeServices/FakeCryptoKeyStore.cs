using System;
using System.Collections.Generic;
using System.Linq;
using DotNetOpenAuth.Messaging.Bindings;

namespace OAuthStack.FakeServices {
    /// <summary>Implements <see cref="ICryptoKeyStore"/> using a static in-memory list.</summary>
    ///<remarks>
    /// This will persist crypto keys whilst the app is running, but will flush them whenever the app is recycled.
    /// A production system should use a persistent store - such as a relational database - to store crypto keys.
    /// </remarks>
    public class FakeCryptoKeyStore : ICryptoKeyStore {
        /// <summary>This wraps a crypto key so we can store a list of them in memory.</summary>
        private class SymmetricCryptoKey {
            internal readonly string Handle;
            internal readonly string Bucket;
            internal readonly byte[] Secret;
            internal readonly DateTime ExpiresUtc;
            public SymmetricCryptoKey(string bucket, string handle, byte[] secret, DateTime expiresUtc) {
                Handle = handle;
                Bucket = bucket;
                Secret = secret;
                ExpiresUtc = expiresUtc;
            }
        }

        private readonly static List<SymmetricCryptoKey> Keys = new List<SymmetricCryptoKey>();

        public CryptoKey GetKey(string bucket, string handle) {
            return (Keys.Where(k => k.Bucket == bucket && k.Handle == handle).Select(k => new CryptoKey(k.Secret, k.ExpiresUtc)).FirstOrDefault());
        }

        public IEnumerable<KeyValuePair<string, CryptoKey>> GetKeys(string bucket) {
            return Keys.Where(key => key.Bucket == bucket).OrderByDescending(key => key.ExpiresUtc).Select(key => new KeyValuePair<string, CryptoKey>(key.Handle, new CryptoKey(key.Secret, key.ExpiresUtc)));
        }

        public void StoreKey(string bucket, string handle, CryptoKey key) {
            Keys.Add(new SymmetricCryptoKey(bucket, handle, key.Key, key.ExpiresUtc));

        }

        public void RemoveKey(string bucket, string handle) {
            var keyToRemove = Keys.FirstOrDefault(k => k.Bucket == bucket && k.Handle == handle);
            if (keyToRemove != null) Keys.Remove(keyToRemove);
        }
    }
}