namespace new_wr_api.Models
{
    public class ConstructionTypeModel
    {
        public int ParentId { get; set; }
        public string TypeName { get; set; } = string.Empty;
        public string TypeSlug { get; set; } = string.Empty;
    }
}
