namespace new_wr_api.Data
{
    public class Business
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? IdentifierCode { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? Director { get; set; }
        public string? AuthorityPerson { get; set; }
        public string? LegalRepresentative { get; set; }
        public string? UserName { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public string? CreatedUser { get; set; }
        public string? ModifiedUser { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
