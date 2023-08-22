namespace new_wr_api.Models
{
    public class LicenseFeeModel
    {
        public int Id { get; set; }
        public int? ChildrenId { get; set; }
        public string? LicenseFeeNumber { get; set; }
        public DateTime? SignDate { get; set; }
        public string? LicensingAuthorities { get; set; }
        public double? TotalMoney { get; set; }
        public string? FilePDF { get; set; }
        public string? Description { get; set; }
        public LicenseFeeModel? SupplementLicenseFee { get; set; } = null;
    }
}
