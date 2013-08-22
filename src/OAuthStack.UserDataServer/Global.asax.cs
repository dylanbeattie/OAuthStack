using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using log4net;
using OAuthStack.UserDataServer.Infrastructure;

namespace OAuthStack.UserDataServer {
    public class Global : System.Web.HttpApplication {
        protected void Application_Start(object sender, EventArgs e) {
            log4net.Config.XmlConfigurator.Configure();
            var log = LogManager.GetLogger("DotNetOpenAuth");
            log.Info("Starting OAuthStack Resource Server");

            new AppHost().Init();
        }
    }
}