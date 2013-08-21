using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OAuthStack.Common.ServiceModel;
using OAuthStack.Common.Services;
using OAuthStack.FakeServices;
using OAuthStack.UserDataServer.ServiceModel;
using ServiceStack.Logging;
using ServiceStack.WebHost.Endpoints;

namespace OAuthStack.UserDataServer.Infrastructure {
    public class AppHost : AppHostBase {
        public AppHost() //Tell ServiceStack the name and where to find your web services
            : base("OAuth2 Demo Resource Server", typeof(UserService).Assembly) { }

        public override void Configure(Funq.Container container) {
            //Set JSON web services to return idiomatic JSON camelCase properties
            ServiceStack.Text.JsConfig.EmitCamelCaseNames = true;

            //Configure User Defined REST Paths
            Routes
              .Add<Users>("/users")
              .Add<Users>("/users/{Username}");


            //Register all your dependencies		
            container.RegisterAutoWiredAs<FakeCryptoKeyProvider, ICryptoKeyProvider>();
            container.RegisterAutoWiredAs<FakeUserStore, IUserStore>();
        }
    }
}
