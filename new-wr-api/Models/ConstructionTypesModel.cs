namespace new_wr_api.Models
{
    public class ConstructionTypesModel
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string? TypeName { get; set; }
        public string? TypeSlug { get; set; }
        public string? Description { get; set; }
    }
}
