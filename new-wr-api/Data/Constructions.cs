﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace new_wr_api.Data
{
    public class Constructions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? ConstructionTypeId { get; set; }
        public int? ProvinceId { get; set; }
        public int? DistrictId { get; set; }
        public int? CommuneId { get; set; }
        public int? RiverId { get; set; }
        public int? BasinId { get; set; }
        public int? SubBasinId { get; set; }
        public int? AquiferId { get; set; }
        public string? UserName { get; set; }
        public string? ConstructionName { get; set; }
        public string? ConstructionCode { get; set; }
        public string? ConstructionLocation { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }
        public int? StartDate { get; set; }
        public string? ExploitedWS { get; set; }
        public string? ExploitMode { get; set; }
        public string? ExploitPurpose { get; set; }
        public string? DischargeMethod { get; set; }
        public string? DischargeMode { get; set; }
        public string? DischargeWS { get; set; }
        public double? DischargeFlow { get; set; }
        public double? MaximumDischargeFlow { get; set; }
        public double? ExploitMaxFlow { get; set; }
        public double? PumpCapacity { get; set; }
        public double? OverflowFlow { get; set; }
        public double? PreFlootMaxWL { get; set; }
        public double? FlootWL { get; set; }
        public double? UpstreamWL { get; set; }
        public double? DownstreamWL { get; set; }
        public double? PumpDesignFlow { get; set; }
        public double? PumpMaxFlow { get; set; }
        public double? SuctionTankWL { get; set; }
        public string? ExploitDuration { get; set; }
        public string? DrillingDuration { get; set; }
        public string? DrillingPurpose { get; set; }
        public string? ExplorationPurposes { get; set; }
        public string? DrillingScale { get; set; }
        public string? ConstructionTime { get; set; }
        public double? NumberExploitWells { get; set; }
        public double? NumberMonitoringWells { get; set; }
        public string? Description { get; set; }
        public string? WellNumber { get; set; }
        public string? VolumeOfExplorationItems { get; set; }
        public double? WaterExtractionFlowDesign { get; set; }
        public double? WaterExtractionFlowReality { get; set; }
        public string? WasteDischargeLocation { get; set; }
        public string? SmallPlanningArea { get; set; }
        public double? MaximumDischargeFlowPre { get; set; }
        public double? CapacityPre { get; set; }
        public double? DownstreamWLPre { get; set; }
        public double? UpstreamWLPre { get; set; }
        public double? MinimumFlowPre { get; set; }
        public double? MaximumFlowPre { get; set; }
        public DateTime? TimePre { get; set; }
        public Nullable<bool> IsDisconnect { get; set; }
        public Nullable<bool> IsError { get; set; }
        public string? Change { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public string? ModifiedUser { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    }
}
