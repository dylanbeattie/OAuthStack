using OAuthStack.Common.Infrastructure;
using OAuthStack.Common.ServiceModel;
using OAuthStack.Common.Services;
using ServiceStack.ServiceInterface;

namespace OAuthStack.UserDataServer.ServiceModel {
    [RequireOAuth2Scope("user_info")]
    public class UserService : Service {
        private readonly IUserStore userStore;

        public UserService(IUserStore userStore) {
            this.userStore = userStore;
        }

        public User Any(Users users) {
            return (userStore.GetUser(users.Username));
        }
    }
}