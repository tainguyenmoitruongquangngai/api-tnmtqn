namespace new_wr_api.Dto
{
    public class SongDto
    {
        public int Id { get; set; }
        public int? IdLuuVuc { get; set; }
        public int? IdXa { get; set; }
        public int? IdHuyen { get; set; }
        public string? Name { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }
        public double? Qtt { get; set; }
        public string? ChuGiai { get; set; }
        public DateTime? ThoiGianTao { get; set; }
        public string? TaiKhoanTao { get; set; }
        public DateTime? ThoiGianSua { get; set; }
        public string? TaiKhoanSua { get; set; }
        public bool? DaXoa { get; set; }
        public int? PartRiverId { get; set; }

        public LuuVucSongDto? luuvuc_song { get; set; }
        public DonViHCDto? donvi_hc {  get; set; }
    }
}
