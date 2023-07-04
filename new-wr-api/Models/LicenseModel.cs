namespace new_wr_api.Models
{
    public class LicenseModel
    {
        public int Id { get; set; }
        public string LicenseName { get; set; } = string.Empty;
        public string LicenseNumber { get; set; } = string.Empty;
        public DateTime? SignDate { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string Duration { get; set; } = string.Empty;
        public int LicensingAuthorities { get; set; }
        public string LicenseFile { get; set; } = string.Empty;
        public string RelatedDocumentFile { get; set; } = string.Empty;
        public string LicenseRequestFile { get; set; } = string.Empty;
        public bool IsRevoked { get; set; } = false;
    }
}
