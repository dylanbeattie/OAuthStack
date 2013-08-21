using System.Collections.Generic;
using System.Linq;
using OAuthStack.Common.ServiceModel;
using OAuthStack.Common.Services;

namespace OAuthStack.FakeServices {
    /// <summary>A fake in-memory implementation of a user database.</summary>
    public class FakeUserStore : IUserStore {
        private static List<User> users = new List<User>();
        static FakeUserStore() {
            users.Add(new User { Username = "evh", Password = "eddie5150", Forenames = "Eddie", Surname = "Van Halen", Email = "eddie@van-halen.com" });
            users.Add(new User { Username = "satch", Password = "surfer101", Forenames = "Joe", Surname = "Satriani", Email = "joe@satch.com" });
            users.Add(new User { Username = "knopfler", Password = "5ultans", Forenames = "Mark", Surname = "Knopfler", Email = "mark@money4nothing.com" });
            users.Add(new User { Username = "matt_b", Password = "Hy5teria", Forenames = "Matt", Surname = "Bellamy", Email = "matt@muse.mu" });
        }
        public User GetUser(string username) {
            return (users.FirstOrDefault(user => user.Username == username));
        }
    }
}