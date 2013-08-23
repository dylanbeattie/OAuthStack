OAuthStack
==========

A sample project demonstrating the *resource owner password flow* in OAuth2, with separate authorization and resource servers. This also demonstrates using DotNetOpenAuth to secure access to resources hosted by a ServiceStack-powered ReST API.

If you're using this as a template for your own production implementation, [search the source for comments containing **TODO**](https://github.com/dylanbeattie/OAuthStack/search?q=TODO&ref=cmdform) - that (I think!) should highlight the areas where you'll need to plug in your own code, data or implementations.

--------

###Known Issues###

Some people have reported problems restoring NuGet packages related to Microsoft.Bcl.Build. These appear to be caused by [http://blogs.msdn.com/b/dotnet/archive/2013/08/22/improved-package-restore.aspx](http://blogs.msdn.com/b/dotnet/archive/2013/08/22/improved-package-restore.aspx)

To work around this, I've checked the /packages/Microsoft.Bcl.Build.* folders into source control. Yeah, I know you're not supposed
to check in your /packages folder, but until there's a clean resolution for this issue this is the easiest way
to make sure it'll build from a clean checkout.

--------

###Points of Interest###

**OAuth2/ServiceStack integration**

This was actually not that complex once I had an OAuth2 infrastructure up and running:

**Server-side:** Take a look at [OAuthStack.Common.Infrastructure.RequireOAuth2ScopeAttribute](https://github.com/dylanbeattie/OAuthStack/blob/master/src/OAuthStack.Common/Infrastructure/RequireOAuth2ScopeAttribute.cs) - this is a ServiceStack RequestFilterAttribute that uses DotNetOpenAuth to verify that the request is authorised to access a specific service.

**Client-side:** we're using the ServiceStack client's LocalHttpWebRequestFilter property to hook in some code that calls DotNetOpenAuth's ClientBase.AuthorizeRequest() method before the request is sent to the server. Check out the [getResourceButton_Click](https://github.com/dylanbeattie/OAuthStack/blob/master/src/OAuthStack.DemoClient/Form1.cs#L86) method in DemoClient\Form1.cs.


**Reading OAuth2 crypto keys from X509 certificate files**

Instead of the hard-wired crypto keys in the DotNetOpenAuth samples, we're reading the public and private keys from X.509 certificates (which I've created using [SelfCert](http://blog.pluralsight.com/2012/02/13/selfcert-create-a-self-signed-certificate-interactively-gui-or-programmatically-in-net/) from PluralSight) - have a look at the constructors on [OAuthStack.Common.Security.CryptoKeyPair.cs](https://github.com/dylanbeattie/OAuthStack/blob/master/src/OAuthStack.Common/Security/CryptoKeyPair.cs)

----------

###Project Structure###

- **OAuthStack.AuthServer** is the OAuth authorization server. Based on the sample authorization server included with DotNetOpenAuth, it's based on ASP.NET MVC 4. This example exposes a single action method - `/oauth2/token` - which will accept a username/password supplied in an HTTP Authentication header, and return an OAuth2 access token + refresh token.
- **OAuthStack.UserDataServer** exposes a really simple ReST API - users can `GET /users/{username}` to retrieve information about themselves. Anonymous access is not permitted, and if they try to retrieve another users' information they'll get a `403 Forbidden`
- **OAuthStack.DemoClient** is a WinForms desktop client demonstrating the *resource owner password flow* and various HTTP exchanges involved.
- **OAuthStack.Common** defines the shared entities and interfaces used by the rest of the project
- **OAuthStack.FakeServices** provides fake implementations of the client store, crypto key store and other required services. In a production app, most of these would be replaced by services built on a proper relational database such as MS SQL Server.

----------

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

