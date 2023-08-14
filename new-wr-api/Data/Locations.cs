using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace new_wr_api.Data
{
    public class Locations
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? CityName { get; set; }
        public string? CityId { get; set; }
        public string? DistrictName { get; set; }
        public string? DistrictId { get; set; }
        public string? CommuneName { get; set; }
        public string? CommuneId { get; set; }
        public string? CommuneLevel { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public string? CreatedByUser { get; set; }
        public string? ModifiedByUser { get; set; }
        public bool IsDeleted { get; set; }
    }
}
