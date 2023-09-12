using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace new_wr_api.Data
{
    public class ConstructionItems
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ConstructionId { get; set; }
        public int? AquiferId { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public string? ModifiedUser { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
