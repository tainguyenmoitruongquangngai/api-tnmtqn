using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace new_wr_api.Data
{
    public class Licenses
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ParentId { get; set; }
        public int LicensingTypeId { get; set; }
        public int BusinessId { get; set; }
        public string? LicenseName { get; set; } = string.Empty;
        public string? LicenseNumber { get; set; } = string.Empty;
        public DateTime? SignDate { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string? Duration { get; set; } = string.Empty;
        public int? LicensingAuthorities { get; set; }
        public string? LicenseFile { get; set; } = string.Empty;
        public string? RelatedDocumentFile { get; set; } = string.Empty;
        public string? LicenseRequestFile { get; set; } = string.Empty;
        public Nullable<bool> IsRevoked { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string? CreatedUser { get; set; } = string.Empty;
        public DateTime? ModifiedTime { get; set; }
        public string? ModifiedUser { get; set; } = string.Empty;
        public Nullable<bool> IsDeleted { get; set; }
    }
}
