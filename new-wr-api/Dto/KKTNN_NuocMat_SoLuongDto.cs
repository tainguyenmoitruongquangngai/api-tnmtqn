namespace new_wr_api.Dto
{
    public class KKTNN_NuocMat_SoLuong_SongSuoiDto
    {
        public int? Id { get; set; }
        public int? IdSong { get; set; }
        public string? ChayRa { get; set; }
        public double? ChieuDai { get; set; }
        public string? ChieuDaiThuocTinh_ThanhPho { get; set; }
        public SongDto? Song { get; set; }
    }
    public class KKTNN_NuocMat_SoLuong_AoHoDamPhaDto
    {
        public int? Id { get; set; }
        public string? Ten { get; set; }
        public string? NguonNuocKhaiThac { get; set; }
        public string? ThuocHeThongSong { get; set; }
        public double? DienTichMatNuoc { get; set; }
        public double? DungTichToanBo { get; set; }
        public double? DungTichHuuIch { get; set; }
        public string? Xa { get; set; }
        public string? Huyen { get; set; }
        public string? MucDich { get; set; }

    }
}
