using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using DotNetOpenAuth.Messaging;
using DotNetOpenAuth.OAuth2;
using DotNetOpenAuth.OAuth2.Messages;
using OAuthStack.Common.Services;
using ServiceStack;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;
using ServiceStack.Text;
using ServiceStack.WebHost.Endpoints;
using HttpRequestWrapper = System.Web.HttpRequestWrapper;

namespace OAuthStack.Common.Infrastructure {
    /// <summary>Restrict this service to clients with a valid OAuth2 access 
    /// token granting access to the specified scopes.</summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true)]
    public class RequireOAuth2ScopeAttribute : RequestFilterAttribute {
        private readonly string[] oauth2Scopes;
        public RequireOAuth2ScopeAttribute(params string[] oauth2Scopes) {
            this.oauth2Scopes = oauth2Scopes;
        }

        public override void Execute(IHttpRequest request, IHttpResponse response, object requestDto) {
            try {
                var authServerKeys = AppHostBase.Instance.Container.ResolveNamed<ICryptoKeyPair>("authServer");
                var dataServerKeys = AppHostBase.Instance.Container.ResolveNamed<ICryptoKeyPair>("dataServer");
                var tokenAnalyzer = new StandardAccessTokenAnalyzer(authServerKeys.PublicSigningKey, dataServerKeys.PrivateEncryptionKey);
                var oauth2ResourceServer = new DotNetOpenAuth.OAuth2.ResourceServer(tokenAnalyzer);
                var wrappedRequest = new HttpRequestWrapper((HttpRequest)request.OriginalRequest);
                HttpContext.Current.User = oauth2ResourceServer.GetPrincipal(wrappedRequest, oauth2Scopes);
            } catch (ProtocolFaultResponseException x) {
                HandleOAuth2Exception(request, response, x);
            }
        }

        private static void HandleOAuth2Exception(IHttpRequest req, IHttpResponse res, ProtocolFaultResponseException ex) {
            var response = ex.CreateErrorResponse();
            if (ex.ErrorResponseMessage is UnauthorizedResponse) {
                var oauth2Error = ex.ErrorResponseMessage as UnauthorizedResponse;
                response.Body = JsonSerializer.SerializeToString(oauth2Error.ToOAuth2JsonResponse());
                response.Headers[HttpResponseHeader.ContentType] = "application/json";
            }
            var context = ((HttpRequest)req.OriginalRequest).RequestContext.HttpContext;
            response.Respond(context);
            res.EndRequest();
        }
    }

    public static class UnauthorizedResponseExtensions {
        public static object ToOAuth2JsonResponse(this UnauthorizedResponse response) {
            return (new {
                error = response.ErrorCode,
                error_description = response.ErrorDescription,
                error_uri = response.ErrorUri
            });
        }
    }
}
