namespace new_wr_api.Models
{
    public class ConstructionDetailModel
    {
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
        public double? MiningMaxFlow { get; set; }
        public string? MiningMode { get; set; }
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
    }
}
