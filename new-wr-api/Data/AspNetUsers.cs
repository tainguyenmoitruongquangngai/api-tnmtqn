using Microsoft.AspNetCore.Identity;

namespace new_wr_api.Data
{
    public partial class AspNetUsers : IdentityUser
    {
        public string? PasswordSalt { get; set; }
        public string? FullName { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public string? ModifiedUser { get; set; }
        public bool Status { get; set; }
        public bool IsDeleted { get; set; }
    }
}
