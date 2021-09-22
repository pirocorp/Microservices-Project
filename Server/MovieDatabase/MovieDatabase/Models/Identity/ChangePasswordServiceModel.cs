namespace MovieDatabase.Models.Identity
{
    public class ChangePasswordServiceModel
    {
        public string UserId { get; set; }

        public string CurrentPassword { get; set; }

        public string NewPassword { get; set; }
    }
}
