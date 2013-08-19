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
        private readonly ICryptoKeyProvider keyProvider;
        private readonly IOAuth2ClientStore clientStore;

        public ExampleAuthorizationServer(ICryptoKeyStore cryptoKeyStore, ICryptoKeyProvider keyProvider, IOAuth2ClientStore clientStore) {
            this.cryptoKeyStore = cryptoKeyStore;
            this.keyProvider = keyProvider;
            this.clientStore = clientStore;
        }

        public AccessTokenResult CreateAccessToken(IAccessTokenRequest accessTokenRequestMessage) {
            var accessToken = new AuthorizationServerAccessToken();

            // Just for the sake of the sample, we use a short-lived token.  This can be useful to mitigate the security risks
            // of access tokens that are used over standard HTTP.
            // But this is just the lifetime of the access token.  The client can still renew it using their refresh token until
            // the authorization itself expires.
            // TODO: implementation of lifespan.
            accessToken.Lifetime = TimeSpan.FromSeconds(15);

            // Also take into account the remaining life of the authorization and artificially shorten the access token's lifetime
            // to account for that if necessary.
            //// TODO: code here

            accessToken.ResourceServerEncryptionKey = keyProvider.RestServerPublicKey;
            accessToken.AccessTokenSigningKey = keyProvider.AuthServerPrivateKey;

            var result = new AccessTokenResult(accessToken);
            return result;
        }

        public IClientDescription GetClient(string clientIdentifier) {
            return (clientStore.GetClient(clientIdentifier));
        }

        public bool IsAuthorizationValid(IAuthorizationDescription authorization) {
            return this.IsAuthorizationValid(authorization.Scope, authorization.ClientIdentifier, authorization.UtcIssued, authorization.User);
        }

        public AutomatedUserAuthorizationCheckResponse CheckAuthorizeResourceOwnerCredentialGrant(string userName, string password, IAccessTokenRequest accessRequest) {
            //TODO: implement this.
            return (new AutomatedUserAuthorizationCheckResponse(accessRequest, true, userName));
        }

        public AutomatedAuthorizationCheckResponse CheckAuthorizeClientCredentialsGrant(IAccessTokenRequest accessRequest) {
            //TODO: implement this
            return (new AutomatedAuthorizationCheckResponse(accessRequest, true));
        }

        public ICryptoKeyStore CryptoKeyStore { get { return (cryptoKeyStore); } }
        public INonceStore NonceStore { get { throw (new NotImplementedException()); } }


        public bool CanBeAutoApproved(EndUserAuthorizationRequest authorizationRequest) {
            //TODO: implement this
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
            // TODO: implement this
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