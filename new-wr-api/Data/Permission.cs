using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace new_wr_api.Data
{
    public class Permission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? UserId { get; set; }
        public string? RoleId { get; set; }
        public string? RoleName { get; set; }
        public string? DashboardId { get; set; }
        public string? PermitName { get; set; }
        public string? PermitCode { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public string? CreatedUser { get; set; }
        public string? ModifiedUser { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<bool> IsDeleted { get; set; }

    }
}
