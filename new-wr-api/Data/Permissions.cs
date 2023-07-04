using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace new_wr_api.Data
{
    public class Permissions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        public string RoleId { get; set; } = string.Empty;
        public string RoleName { get; set; } = string.Empty;
        public string DashboardId { get; set; } = string.Empty;
        public string PermitName { get; set; } = string.Empty;
        public string PermitCode { get; set; } = string.Empty;
        public DateTime? CreatedTime { get; set; }
        public string CreatedUser { get; set; } = string.Empty;
        public DateTime? ModifiedTime { get; set; }
        public string ModifiedUser { get; set; } = string.Empty;
        public bool Status { get; set; }
        public bool IsDeleted { get; set; }

    }
}
