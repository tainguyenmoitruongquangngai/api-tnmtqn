namespace new_wr_api.Models
{
    public class ConstructionItemModel
    {
        public int Id { get; set; }
        public int ConstructionId { get; set; }
        public int? AquiferId { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }
        public double? Lat { get; set; }
        public double? Lng { get; set; }
        public string? Description { get; set; }

        public ConstructionSpecificationModel? ConstructionSpecification { get; set; }
    }
}
