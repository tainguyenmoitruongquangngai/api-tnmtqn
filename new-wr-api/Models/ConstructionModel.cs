﻿namespace new_wr_api.Models
{
    public class ConstructionModel
    {
        public int Id { get; set; }
        public int ConstructionTypeId { get; set; }
        public int ProvinceId { get; set; }
        public int DistrictId { get; set; }
        public int CommuneId { get; set; }
        public int RiverId { get; set; }
        public int BasinId { get; set; }
        public int SubBasinId { get; set; }
        public int LicenseId { get; set; }
        public int AquiferId { get; set; }
        public string? UserName { get; set; }
        public string? ConstructionName { get; set; }
        public string? ConstructionCode { get; set; }
        public string? ConstructionLocation { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }
        public double? Lat { get; set; }
        public double? Lng { get; set; }
        public int StartDate { get; set; }
        public string? ExploitedWS { get; set; }
        public string? ExploitMode { get; set; }
        public string? ExploitMethod { get; set; }
        public string? ExploitPurpose { get; set; }
        public string? DischargeMethod { get; set; }
        public string? DischargeMode { get; set; }
        public string? DischargeWS { get; set; }
        public double? DischargeFlow { get; set; }
        public double? MaximumDischargeFlow { get; set; }
        public double? ExploitMaxFlow { get; set; }
        public double? MaximumFlow { get; set; }
        public double? MinimumFlow { get; set; }
        public double? MaximumWasteWaterFlow { get; set; }
        public double? Power { get; set; }
        public double? PumpCapacity { get; set; }
        public double? OverflowFlow { get; set; }
        public double? RiseWL { get; set; }
        public double? DeadWL { get; set; }
        public double? PreFlootMaxWL { get; set; }
        public double? FlootWL { get; set; }
        public double? UpstreamWL { get; set; }
        public double? DownstreamWL { get; set; }
        public double? DeadCapacity { get; set; }
        public double? UsefulCapacity { get; set; }
        public double? TotalCapacity { get; set; }
        public double? DamHeight { get; set; }
        public double? DamWidth { get; set; }
        public double? DrainElevation { get; set; }
        public double? DrainLength { get; set; }
        public double? DrainDiameter { get; set; }
        public double? DrainSize { get; set; }
        public double? PumpNumber { get; set; }
        public double? PumpDesignFlow { get; set; }
        public double? PumpMaxFlow { get; set; }
        public double? SuctionTankWL { get; set; }
        public double? WaterSupplyFlow { get; set; }
        public string? ExploitDuration { get; set; }
        public string? DrillingDuration { get; set; }
        public string? DrillingPurpose { get; set; }
        public string? ExplorationPurposes { get; set; }
        public string? DrillingScale { get; set; }
        public string? ConstructionTime { get; set; }
        public double? DesignFloodLevel { get; set; }
        public double? CheckFloodWL { get; set; }
        public double? NumberExploitWells { get; set; }
        public double? AmountWaterExploited { get; set; }
        public double? NumberMonitoringWells { get; set; }
        public string? Description { get; set; }
        public string? WellNumber { get; set; }
        public double? MonitoringWellWL { get; set; }
        public double? WellWL { get; set; }
        public double? WaterDepthFrom { get; set; }
        public double? WaterDepthTo { get; set; }
        public double? LowWL { get; set; }
        public double? StaticWL { get; set; }
        public double? DynamicWL { get; set; }
        public string? VolumeOfExplorationItems { get; set; }
        public double? WaterExtractionFlowDesign { get; set; }
        public double? WaterExtractionFlowReality { get; set; }
        public string? ConstructionDetailLocation { get; set; }
        public double? RealityWateringArea { get; set; }
        public double? WateringAreaDesigned { get; set; }
        public double? GuaranteedFlow { get; set; }
        public double? Hmax { get; set; }
        public double? Hmin { get; set; }
        public double? Htt { get; set; }
        public double? RealityFlow { get; set; }
        public double? FlowDesigned { get; set; }
        public double? FlowAvgForYears { get; set; }
        public double? RainAvgForYears { get; set; }
        public double? BasinArea { get; set; }
        public double? AverageDischargeFlow { get; set; }
        public string? SmallPlanningArea { get; set; }
        public double? GuaranteedPower { get; set; }
        public string? ConstructionLevel { get; set; }
        public string? KqKf { get; set; }
        public double? DamElevation { get; set; }
        public string? AveragePumpTime { get; set; }
        public string? MaximumPumpTime { get; set; }
        public string? MinimumPumpTime { get; set; }
        public double? MaximumDischargeFlowPre { get; set; }
        public double? CapacityPre { get; set; }
        public double? DownstreamWLPre { get; set; }
        public double? UpstreamWLPre { get; set; }
        public double? MinimumFlowPre { get; set; }
        public double? MaximumFlowPre { get; set; }
        public DateTime? TimePre { get; set; }
        public bool IsDisconnect { get; set; }
        public bool IsError { get; set; }
        public string? Change { get; set; }


        //get more data
        public List<ConstructionDetailModel>? ConstructionItems { get; set; }
        public List<LicenseModel>? Licenses { get; set; }
        public string? ConstructionTypeName { get; set; }
        public string? ConstructionTypeSlug { get; set; }
        public string? DistrictName { get; set; }
        public string? CommuneName { get; set; }
        public string? RiverName { get; set; }
        public string? BasinName { get; set; }
        public string? SubBasinName { get; set; }
        public string? AquiferName { get; set; }
    }
}
