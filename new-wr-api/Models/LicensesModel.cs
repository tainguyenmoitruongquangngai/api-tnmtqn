namespace new_wr_api.Models
{
    public class LicensesModel
    {
        public string? LicenseName { get; set; }
        public string? LicenseNumber { get; set; }
        public System.DateTime SignDate { get; set; }
        public Nullable<System.DateTime> IssueDate { get; set; }
        public Nullable<System.DateTime> ExpireDate { get; set; }
        public string? Duration { get; set; }
        public Nullable<int> LicensingAuthorities { get; set; }
        public string? LicenseFile { get; set; }
        public string? RelatedDocumentFile { get; set; }
        public string? LicenseRequestFile { get; set; }
    }
}
