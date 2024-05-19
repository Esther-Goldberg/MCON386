using System.Data;

namespace MCON368.Entity
{
    public class UserProfileEntity
    {
        public int UserProfileKey { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int CreatedByUserProfileKey { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public bool ActiveInd { get; set; }
        public string ErrorMessage { get; set; }
        public string DisplayName { get; set; }
        public DateTime LastRefreshed { get; set; }
        public StartUpObjectEntity StartupObjects { get; set; }
        public string? SQLUserName { get; set; }

    }
}
