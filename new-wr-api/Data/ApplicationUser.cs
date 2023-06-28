using Microsoft.AspNetCore.Identity;

namespace new_wr_api.Data
{
    public partial class ApplicationUser : IdentityUser
    {
        public string PasswordSalt { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string UserType { get; set; } = string.Empty;
        public bool IsDelete { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public string? CreatedUser { get; set; }
        public string? ModifiedUser { get; set; }
    }
}
