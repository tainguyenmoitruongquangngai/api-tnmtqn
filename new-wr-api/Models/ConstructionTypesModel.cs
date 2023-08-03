namespace new_wr_api.Models
{
    public class ConstructionTypesModel
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string? TypeName { get; set; } = string.Empty;
        public string? TypeSlug { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        public DateTime? CreatedTime { get; set; }
        public string? CreatedUser { get; set; } = string.Empty;
        public DateTime? ModifiedTime { get; set; }
        public string? ModifiedUser { get; set; } = string.Empty;
        public Nullable<bool> Status { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    }
}
