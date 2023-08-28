using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace new_wr_api.Data
{
    public class ConstructionDetails
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
        public double? Lat { get; set; }
        public double? Lng { get; set; }
        public double? WaterSupplyFlow { get; set; }
        public double? WaterDepthFrom { get; set; }
        public double? WaterDepthTo { get; set; }
        public double? DepthFilterTubeFrom { get; set; }
        public double? DepthFilterTubeTo { get; set; }
        public double? StaticWL { get; set; }
        public double? DynamicWL { get; set; }
        public double? ExploitMaxFlow { get; set; }
        public string? ExploitMode { get; set; }
        public double? AmountWaterExploited { get; set; }
        public double? PumpCapacity { get; set; }
        public double? MaximumWasteWaterFlow { get; set; }
        public double? AverageDischargeFlow { get; set; }
        public string? KqKf { get; set; }
        public string? DischargeWS { get; set; }
        public string? DischargeMethod { get; set; }
        public string? DischargeMode { get; set; }
        public double? LowWL { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public string? ModifiedUser { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
