namespace OAuthStack.Common.ServiceModel {
    public class User {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Forenames { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public bool VerifyPassword(string password) {
            return (password == this.Password);
        }
    }
}