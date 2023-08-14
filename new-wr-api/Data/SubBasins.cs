using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace new_wr_api.Data
{
    public class SubBasins
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int BasinId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string? ModifiedUser { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
