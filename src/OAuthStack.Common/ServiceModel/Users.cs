using OAuthStack.Common.Services;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace OAuthStack.Common.ServiceModel {
    public class Users : IReturn<User> {
        public string Username { get; set; }
    }
}