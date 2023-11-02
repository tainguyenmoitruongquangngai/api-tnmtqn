namespace new_wr_api.Dto
{
    public class GS_SoLieuDto
    {
        public int? Id { get; set; }
        public string? TenCT { get; set; }
        public string? MaCT { get; set; }
        public CT_LoaiDto? loaiCT { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }
        public double? QXaMaxTT { get; set; }
        public double? DungTichTT { get; set; }
        public double? HHaLuuTT { get; set; }
        public double? HThuongLuuTT { get; set; }
        public double? QMinTT { get; set; }
        public double? QMaxTT { get; set; }
        public double? QXaTranTT { get; set; }
        public double? DCTTTT { get; set; }
        public DateTime? ThoiGian { get; set; }
        public int? MatKetNoi { get; set; }
        public int? Loi { get; set; }
        public CT_ThongSoDto? thongso { get; set; }
    }
}
