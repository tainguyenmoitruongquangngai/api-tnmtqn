namespace new_wr_api.Models
{
    public class LicensesModel
    {
        public string? LicenseNumber { get; set; }
        public string? LicenseName { get; set; }
        public DateTime? SignDate { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string? Duration { get; set; }
        public string? LicenseFile { get; set; }
        public string? RelatedDocumentFile { get; set; }
        public string? LicenseRequestFile { get; set; }
    }
}
