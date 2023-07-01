namespace new_wr_api.Models
{
    public class LicenseModel
    {
        public string LicenseName { get; set; } = string.Empty;
        public string LicenseNumber { get; set; } = string.Empty;
        public System.DateTime SignDate { get; set; }
        public Nullable<System.DateTime> IssueDate { get; set; }
        public Nullable<System.DateTime> ExpireDate { get; set; }
        public string Duration { get; set; } = string.Empty;
        public int LicensingAuthorities { get; set; }
        public string LicenseFile { get; set; } = string.Empty;
        public string RelatedDocumentFile { get; set; } = string.Empty;
        public string LicenseRequestFile { get; set; } = string.Empty;
    }
}
