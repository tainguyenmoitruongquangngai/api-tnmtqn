namespace new_wr_api.Models
{
    public class RiverModel
    {
        public int Id { get; set; }
        public int? BasinId { get; set; }
        public int? LocationId { get; set; }
        public string? Name { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }
        public double? Long { get; set; }
        public double? Lat { get; set; }
        public double? Qtt { get; set; }
        public string? Description { get; set; }

        //More data
        public BasinModel? Basin { get; set; }
        public LocationsModel? Location { get; set; }
    }
}
