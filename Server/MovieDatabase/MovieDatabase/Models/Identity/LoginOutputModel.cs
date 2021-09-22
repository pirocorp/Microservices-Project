namespace MovieDatabase.Models.Identity
{
    public class LoginOutputModel
    {
        public LoginOutputModel(string token, string userId)
        {
            this.Token = token;
            this.UserId = userId;
        }

        public string Token { get; }

        public string UserId { get; }
    }
}
