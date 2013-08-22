using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotNetOpenAuth.Messaging.Bindings;
using DotNetOpenAuth.OAuth2;
using DotNetOpenAuth.OAuth2.ChannelElements;
using DotNetOpenAuth.OAuth2.Messages;
using OAuthStack.Common.Services;

namespace OAuthStack.AuthServer.OAuth2 {
    public class ExampleAuthorizationServer : IAuthorizationServerHost {

        private readonly ICryptoKeyStore cryptoKeyStore;
        private readonly ICryptoKeyPair authServerKeys;
        private readonly ICryptoKeyPair dataServerKeys;
        private readonly IOAuth2ClientStore clientStore;
        private readonly IUserStore userStore;

        public ExampleAuthorizationServer(ICryptoKeyStore cryptoKeyStore,
            ICryptoKeyPair authServerKeys, ICryptoKeyPair dataServerKeys, IOAuth2ClientStore clientStore, IUserStore userStore) {
            this.cryptoKeyStore = cryptoKeyStore;
            this.authServerKeys = authServerKeys;
            this.dataServerKeys = dataServerKeys;
            this.clientStore = clientStore;
            this.userStore = userStore;
        }

        public AccessTokenResult CreateAccessToken(IAccessTokenRequest accessTokenRequestMessage) {
            var accessToken = new AuthorizationServerAccessToken();

            // TODO: work out and implement appropriate lifespan for access tokens based on your specific application requirements
            accessToken.Lifetime = TimeSpan.FromSeconds(15);

            // TODO: artificially shorten the access token's lifetime if the original authorization is due to expire sooner than the default lifespan.
            // (i.e. don't give out 7-day access tokens to somebody who has only granted your app access for 24 hours) 
            accessToken.ResourceServerEncryptionKey = dataServerKeys.PublicSigningKey;
            accessToken.AccessTokenSigningKey = authServerKeys.PrivateEncryptionKey;
            return (new AccessTokenResult(accessToken));
        }

        public IClientDescription GetClient(string clientIdentifier) {
            return (clientStore.GetClient(clientIdentifier));
        }

        public bool IsAuthorizationValid(IAuthorizationDescription authorization) {
            return this.IsAuthorizationValid(authorization.Scope, authorization.ClientIdentifier, authorization.UtcIssued, authorization.User);
        }

        public AutomatedUserAuthorizationCheckResponse CheckAuthorizeResourceOwnerCredentialGrant(string userName, string password, IAccessTokenRequest accessRequest) {
            //TODO: this is where the OAuth2 server checks the client username/password are correct. Replace this with your own implementation.
            var user = userStore.GetUser(userName);
            var approved = (user != null && user.VerifyPassword(password));
            return (new AutomatedUserAuthorizationCheckResponse(accessRequest, approved, userName));
        }

        public AutomatedAuthorizationCheckResponse CheckAuthorizeClientCredentialsGrant(IAccessTokenRequest accessRequest) {
            //TODO: if you're using web-based redirect login, this is where you verify the client's access token request is valid.
            return (new AutomatedAuthorizationCheckResponse(accessRequest, true));
        }

        public ICryptoKeyStore CryptoKeyStore { get { return (cryptoKeyStore); } }
        public INonceStore NonceStore { get { throw (new NotImplementedException()); } }


        public bool CanBeAutoApproved(EndUserAuthorizationRequest authorizationRequest) {
            //TODO: make sure we have a valid client secret on file matching that included with the authorization request
            return (true);
            //if (authorizationRequest == null) {
            //    throw new ArgumentNullException("authorizationRequest");
            //}

            //// NEVER issue an auto-approval to a client that would end up getting an access token immediately
            //// (without a client secret), as that would allow arbitrary clients to masquarade as an approved client
            //// and obtain unauthorized access to user data.
            //if (authorizationRequest.ResponseType == EndUserAuthorizationResponseType.AuthorizationCode) {
            //    // Never issue auto-approval if the client secret is blank, since that too makes it easy to spoof
            //    // a client's identity and obtain unauthorized access.
            //    var requestingClient = MvcApplication.DataContext.Clients.First(c => c.ClientIdentifier == authorizationRequest.ClientIdentifier);
            //    if (!string.IsNullOrEmpty(requestingClient.ClientSecret)) {
            //        return this.IsAuthorizationValid(
            //            authorizationRequest.Scope,
            //            authorizationRequest.ClientIdentifier,
            //            DateTime.UtcNow,
            //            HttpContext.Current.User.Identity.Name);
            //    }
            //}

            //// Default to not auto-approving.
            //return false;
        }

        private bool IsAuthorizationValid(HashSet<string> requestedScopes, string clientIdentifier, DateTime issuedUtc, string username) {
            // TODO: This is where we should check (e.g. in our authorization database) that the resource owner has not revoked the authorization associated with the request.
            return (true);
            // If db precision exceeds token time precision (which is common), the following query would
            // often disregard a token that is minted immediately after the authorization record is stored in the db.
            // To compensate for this, we'll increase the timestamp on the token's issue date by 1 second.
            //issuedUtc += TimeSpan.FromSeconds(1);
            //var grantedScopeStrings = from auth in MvcApplication.DataContext.ClientAuthorizations
            //                          where
            //                              auth.Client.ClientIdentifier == clientIdentifier &&
            //                              auth.CreatedOnUtc <= issuedUtc &&
            //                              (!auth.ExpirationDateUtc.HasValue || auth.ExpirationDateUtc.Value >= DateTime.UtcNow) &&
            //                              auth.User.OpenIDClaimedIdentifier == username
            //                          select auth.Scope;

            //if (!grantedScopeStrings.Any()) {
            //    // No granted authorizations prior to the issuance of this token, so it must have been revoked.
            //    // Even if later authorizations restore this client's ability to call in, we can't allow
            //    // access tokens issued before the re-authorization because the revoked authorization should
            //    // effectively and permanently revoke all access and refresh tokens.
            //    return false;
            //}

            //var grantedScopes = new HashSet<string>(OAuthUtilities.ScopeStringComparer);
            //foreach (string scope in grantedScopeStrings) {
            //    grantedScopes.UnionWith(OAuthUtilities.SplitScopes(scope));
            //}

            //return requestedScopes.IsSubsetOf(grantedScopes);
        }
    }
}