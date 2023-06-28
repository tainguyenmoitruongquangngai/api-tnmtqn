using Microsoft.AspNetCore.Identity;

namespace new_wr_api.Data
{
    public class ApplicationRole : IdentityRole
    {
        public bool IsDefault { get; set; }
        public string Discriminator { get; set; } = "ApplicationRole";
        public bool IsDelete { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public string? CreatedUser { get; set; }
        public string? ModifiedUser { get; set; }

    }
}
