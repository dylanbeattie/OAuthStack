using System;
using System.Web;
using OAuthStack.Common.Infrastructure;
using OAuthStack.Common.ServiceModel;
using OAuthStack.Common.Services;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace OAuthStack.UserDataServer.ServiceModel {
    [RequireOAuth2Scope("user_info")]
    public class UserService : Service {
        private readonly IUserStore userStore;

        public UserService(IUserStore userStore) {
            this.userStore = userStore;
        }

        public User Any(Users users) {
            if (HttpContext.Current.User.Identity.Name != users.Username) {
                throw (new UnauthorizedAccessException(String.Format("Your access token doesn't grant access to information for the user named {0}", users.Username)));
            }
            return (userStore.GetUser(users.Username));
        }
    }
}