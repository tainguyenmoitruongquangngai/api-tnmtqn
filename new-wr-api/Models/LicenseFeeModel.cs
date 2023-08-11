namespace new_wr_api.Models
{
    public class LicenseFeeModel
    {
        public int Id { get; set; }
        public int? ChildrenId { get; set; }
        public string? LicenseFeeNumber { get; set; }
        public DateTime? SignDate { get; set; }
        public int? LicensingAuthorities { get; set; }
        public double? TotalMoney { get; set; }
        public string? FilePDF { get; set; }
        public string? Description { get; set; }
        public FileData? File { get; } = null;
        public LicenseFeeModel? SupplementLicenseFee { get; set; } = null;
    }
}
