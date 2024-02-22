namespace new_wr_api.Dto
{
    public class PhanDoanSongDto
    {
        public int Id { get; set; }
        public string? LuuVucSong { get; set; }
        public string? Song { get; set; }
        public string? TenDoanSong { get; set; }
        public string? PhanDoan { get; set; }
        public double? ChieuDai { get; set; }
        public double? DienTichLV { get; set; }
        public double? XDau { get; set; }
        public double? YDau { get; set; }
        public double? XCuoi { get; set; }
        public double? YCuoi { get; set; }
        public string? DiaGioiHanhChinh { get; set; }
        public string? MucDichSuDung { get; set; }
        public string? ChatLuongNuoc { get; set; }
        public string? GhiChu { get; set; }
        public bool? DaXoa { get; set; }
    }
}
