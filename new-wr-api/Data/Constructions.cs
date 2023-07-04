using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace new_wr_api.Data
{
    public class Constructions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int TypeOfConstructionId { get; set; }
        public int ProvinceId { get; set; }
        public int DistrictId { get; set; }
        public int CommuneId { get; set; }
        public int RiverId { get; set; }
        public int BasinId { get; set; }
        public int LicenseId { get; set; }
        public int AquiferId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string ConstructionName { get; set; } = string.Empty;
        public string ConstructionCode { get; set; } = string.Empty;
        public string ConstructionLocation { get; set; } = string.Empty;
        public double X { get; set; }
        public double Y { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public int StartDate { get; set; }
        public string ExploitedWS { get; set; } = string.Empty;
        public string MiningMode { get; set; } = string.Empty;
        public string MiningMethod { get; set; } = string.Empty;
        public string MiningPurpose { get; set; } = string.Empty;
        public string DischargeMethod { get; set; } = string.Empty;
        public string DischargeMode { get; set; } = string.Empty;
        public string DischargeWS { get; set; } = string.Empty;
        public double DischargeFlow { get; set; }
        public double MaximumDischargeFlow { get; set; }
        public double MiningMaxFlow { get; set; }
        public double MaximumFlow { get; set; }
        public double MinimumFlow { get; set; }
        public double MaximumWasteWaterFlow { get; set; }
        public double Power { get; set; }
        public double PumpCapacity { get; set; }
        public double OverflowFlow { get; set; }
        public double RiseWL { get; set; }
        public double DeadWL { get; set; }
        public double PreFlootMaxWL { get; set; }
        public double FlootWL { get; set; }
        public double UpstreamWL { get; set; }
        public double DownstreamWL { get; set; }
        public double DeadCapacity { get; set; }
        public double UsefulCapacity { get; set; }
        public double TotalCapacity { get; set; }
        public double DamHeight { get; set; }
        public double DamWidth { get; set; }
        public double DrainElevation { get; set; }
        public double DrainLength { get; set; }
        public double DrainDiameter { get; set; }
        public double DrainSize { get; set; }
        public double PumpNumber { get; set; }
        public double PumpDesignFlow { get; set; }
        public double PumpMaxFlow { get; set; }
        public double SuctionTankWL { get; set; }
        public double WaterSupplyFlow { get; set; }
        public string MiningDuration { get; set; } = string.Empty;
        public string DrillingDuration { get; set; } = string.Empty;
        public string DrillingPurpose { get; set; } = string.Empty;
        public string ExplorationPurposes { get; set; } = string.Empty;
        public string DrillingScale { get; set; } = string.Empty;
        public string ConstructionTime { get; set; } = string.Empty;
        public double DesignFloodLevel { get; set; }
        public double CheckFloodWL { get; set; }
        public double NumberMiningWells { get; set; }
        public double AmountWaterExploited { get; set; }
        public double NumberMonitoringWells { get; set; }
        public string Description { get; set; } = string.Empty;
        public string WellNumber { get; set; } = string.Empty;
        public double MonitoringWellWL { get; set; }
        public double WellWL { get; set; }
        public double WaterDepthFrom { get; set; }
        public double WaterDepthTo { get; set; }
        public double LowWL { get; set; }
        public double StaticWL { get; set; }
        public double DynamicWL { get; set; }
        public string VolumeOfExplorationItems { get; set; } = string.Empty;
        public double WaterExtractionFlowDesign { get; set; }
        public double WaterExtractionFlowReality { get; set; }
        public string ConstructionDetailLocation { get; set; } = string.Empty;
        public double RealityWateringArea { get; set; }
        public double WateringAreaDesigned { get; set; }
        public double GuaranteedFlow { get; set; }
        public double Hmax { get; set; }
        public double Hmin { get; set; }
        public double Htt { get; set; }
        public double RealityFlow { get; set; }
        public double FlowDesigned { get; set; }
        public double FlowAvgForYears { get; set; }
        public double RainAvgForYears { get; set; }
        public double BasinArea { get; set; }
        public double AverageDischargeFlow { get; set; }
        public string SmallPlanningArea { get; set; } = string.Empty;
        public double GuaranteedPower { get; set; }
        public string ConstructionLevel { get; set; } = string.Empty;
        public string KqKf { get; set; } = string.Empty;
        public double DamElevation { get; set; }
        public string AveragePumpTime { get; set; } = string.Empty;
        public string MaximumPumpTime { get; set; } = string.Empty;
        public string MinimumPumpTime { get; set; } = string.Empty;
        public double MaximumDischargeFlowPre { get; set; }
        public double CapacityPre { get; set; }
        public double DownstreamWLPre { get; set; }
        public double UpstreamWLPre { get; set; }
        public double MinimumFlowPre { get; set; }
        public double MaximumFlowPre { get; set; }
        public DateTime? TimePre { get; set; }
        public bool IsDisconnect { get; set; }
        public bool IsError { get; set; }
        public string Change { get; set; } = string.Empty;
        public DateTime? CreatedTime { get; set; }
        public string CreatedUser { get; set; } = string.Empty;
        public DateTime? ModifiedTime { get; set; }
        public string ModifiedUser { get; set; } = string.Empty;
        public bool Status { get; set; }
        public bool IsDeleted { get; set; }
    }
}
