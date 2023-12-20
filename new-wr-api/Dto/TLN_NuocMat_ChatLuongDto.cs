namespace new_wr_api.Dto
{
    public class TLN_NuocMat_ChatLuongDto
    {
        public int? Id { get; set; }
        public int? IdXa { get; set; }
        public int? IdHuyen { get; set; }
        public int? IdTinh { get; set; }
        public int? IdLuuVucSong { get; set; }
        public string? ViTriQuanTrac { get; set; }
        public double? GiaTriWQI { get; set; }
        public double? BOD5Max { get; set; }
        public double? BOD5Min { get; set; }
        public double? CODMax { get; set; }
        public double? CODMin { get; set; }
        public double? DOMax { get; set; }
        public double? DOMin { get; set; }
        public string? GhiChu { get; set; }
        public DateTime? ThoiGian { get; set; }
    }
}
