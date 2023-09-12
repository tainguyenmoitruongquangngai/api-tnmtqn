using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace new_wr_api.Models
{
    public class ConstructionSpecificationModel
    {
        public int Id { get; set; }
        public int ConstructionId { get; set; }
        public int? ConstructionItemId { get; set; }
        public double? ConstructionLevel { get; set; }
        public double? BasinArea { get; set; }
        public double? RainAvgForYears { get; set; }
        public double? FlowAvgForYears { get; set; }
        public double? Power { get; set; }
        public double? GuaranteedPower { get; set; }
        public double? DamHeight { get; set; }
        public double? DamWidth { get; set; }
        public double? DamElevation { get; set; }
        public double? MaximumFlow { get; set; }
        public double? MinimumFlow { get; set; }
        public double? GuaranteedFlow { get; set; }
        public double? Hmax { get; set; }
        public double? Hmin { get; set; }
        public double? Htt { get; set; }
        public double? DeadWL { get; set; }
        public double? RiseWL { get; set; }
        public double? DesignFloodLevel { get; set; }
        public double? CheckFloodWL { get; set; }
        public double? TotalCapacity { get; set; }
        public double? DeadCapacity { get; set; }
        public double? UsefulCapacity { get; set; }

        //Drain Take Water
        public double? DrainElevation { get; set; }
        public double? DrainLength { get; set; }
        public double? DrainDiameter { get; set; }
        public double? DrainSize { get; set; }

        //Pump Station
        public double? PumpNumber { get; set; }
        public double? FlowDesigned { get; set; }
        public double? RealityFlow { get; set; }
        public double? WateringAreaDesigned { get; set; }
        public double? RealityWateringArea { get; set; }
        public double? AveragePumpTime { get; set; }
        public double? MinimumPumpTime { get; set; }
        public double? MaximumPumpTime { get; set; }

        //Ground Water
        public double? WaterDepthFrom { get; set; }
        public double? WaterDepthTo { get; set; }
        public double? WaterSupplyFlow { get; set; }
        public double? WellWL { get; set; }
        public double? MonitoringWellWL { get; set; }
        public double? ExploitMethod { get; set; }
        public double? StaticWL { get; set; }
        public double? DynamicWL { get; set; }
        public double? ExploitAquifer { get; set; }
        public double? LowWL { get; set; }
        public double? AmountWaterExploited { get; set; }
        public double? DepthFilterTubeFrom { get; set; }
        public double? DepthFilterTubeTo { get; set; }
        public double? ExploitMaxFlow { get; set; }
        public string? ExploitMode { get; set; }
        public double? PumpCapacity { get; set; }

        //Discharge Water
        public double? AverageDischargeFlow { get; set; }
        public double? MaximumWasteWaterFlow { get; set; }
        public double? KqKf { get; set; }
        public string? DischargeWS { get; set; }
        public string? DischargeMethod { get; set; }
        public string? DischargeMode { get; set; }
    }
}
