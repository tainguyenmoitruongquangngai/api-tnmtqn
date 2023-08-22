using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace new_wr_api.Data
{
    public class LicenseFees
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? ChildrenId { get; set; }
        public string? LicenseFeeNumber { get; set; }
        public DateTime? SignDate { get; set; }
        public string? LicensingAuthorities { get; set; }
        public double? TotalMoney { get; set; }
        public string? FilePDF { get; set; }
        public string? Description { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string? ModifiedUser { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
