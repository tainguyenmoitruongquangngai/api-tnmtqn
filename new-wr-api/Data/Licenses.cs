using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace new_wr_api.Data
{
    public class Licenses
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? LicenseName { get; set; }
        public string? LicenseNumber { get; set; }
        public System.DateTime SignDate { get; set; }
        public Nullable<System.DateTime> IssueDate { get; set; }
        public Nullable<System.DateTime> ExpireDate { get; set; }
        public string? Duration { get; set; }
        public Nullable<int> LicensingAuthorities { get; set; }
        public string? LicenseFile { get; set; }
        public string? RelatedDocumentFile { get; set; }
        public string? LicenseRequestFile { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public string? CreatedUser { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public string? ModifiedUser { get; set; }
        public Nullable<bool> IsRevoked { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    }
}
