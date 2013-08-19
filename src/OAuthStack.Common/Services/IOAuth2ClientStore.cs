using DotNetOpenAuth.OAuth2;

namespace OAuthStack.Common.Services {
    /// <summary>Defines a persistent store for OAuth clients.</summary>
    /// <remarks>
    /// You'll need to implement this, and create a record for each client app that's allowed to connect to your server.
    /// Remember - in OAuth2, 'clients' aren't people, they're applications. You may only have one record in your client store.
    /// </remarks>
    public interface IOAuth2ClientStore {
        IClientDescription GetClient(string clientIdentifier);
    }
}
