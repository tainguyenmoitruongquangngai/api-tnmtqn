using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace new_wr_api.Data
{
    public class ConstructionType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Nullable<int> ParentId { get; set; }
        public string? TypeName { get; set; }
        public string? TypeSlug { get; set; }
        public string? Description { get; set; }
        public Nullable<System.DateTime> CreatedTime { get; set; }
        public string? CreatedUser { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public string? ModifiedUser { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    }
}
