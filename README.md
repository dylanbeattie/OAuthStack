OAuthStack
==========

A sample project demonstrating the *resource owner password flow* in OAuth2, with separate authorization and resource servers. This also demonstrates using DotNetOpenAuth to secure access to resources hosted by a ServiceStack-powered ReST API.

###Points of Interest###

**OAuth2/ServiceStack integration**

 Take a look at [OAuthStack.Common.Infrastructure.RequireOAuth2ScopeAttribute](https://github.com/dylanbeattie/OAuthStack/blob/master/src/OAuthStack.Common/Infrastructure/RequireOAuth2ScopeAttribute.cs) - this is a ServiceStack RequestFilterAttribute that uses DotNetOpenAuth to verify that the request is authorised to access a specific service.

**Reading OAuth2 crypto keys from X509 certificate files**

Instead of the hard-wired crypto keys in the DotNetOpenAuth samples,   



###OAuth2 Terminology###

from [http://tools.ietf.org/html/rfc6749#section-1.1](http://tools.ietf.org/html/rfc6749#section-1.1)

>   **resource owner**
>   
>    An entity capable of granting access to a protected resource. When the resource owner is a person, it is referred to as an end-user.

>  **resource server**
>  
>  The server hosting the protected resources, capable of accepting and responding to protected resource requests using access tokens.

> **client**
> 
> An application making protected resource requests on behalf of the
      resource owner and with its authorization.  The term "client" does
      not imply any particular implementation characteristics (e.g.,
      whether the application executes on a server, a desktop, or other
      devices).

> **authorization server**
> 
> The server issuing access tokens to the client after successfully
      authenticating the resource owner and obtaining authorization.

###Components###

- **OAuthStack.AuthServer** is the OAuth authorization server. Based on the sample authorization server included with DotNetOpenAuth, it's based on ASP.NET MVC 4. This example exposes a single action method - `/oauth2/token` - which will accept a username/password supplied in an HTTP Authentication header, and return an OAuth2 access token + refresh token.
- **OAuthStack.UserDataServer** exposes a really simple ReST API - users can `GET /users/{username}` to retrieve information about themselves. Anonymous access is not permitted, and if they try to retrieve another users' information they'll get a `403 Forbidden`
- **OAuthStack.DemoClient** is a WinForms desktop client demonstrating the *resource owner password flow* and various HTTP exchanges involved.
- **OAuthStack.Common** defines the shared entities and interfaces used by the rest of the project
- **OAuthStack.FakeServices** provides fake implementations of the client store, crypto key store and other required services. In a production app, most of these would be replaced by services built on a proper relational database such as MS SQL Server.



