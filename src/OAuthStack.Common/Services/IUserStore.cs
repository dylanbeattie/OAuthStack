using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OAuthStack.Common.ServiceModel;

namespace OAuthStack.Common.Services {
    public interface IUserStore {
        User GetUser(string username);
    }
}
