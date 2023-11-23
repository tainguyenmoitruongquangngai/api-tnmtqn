using new_wr_api.Data;

namespace new_wr_api.Dto
{
    public class CT_ThongTinDto
    {
        public int? Id { get; set; }
        public int? IdLoaiCT { get; set; }
        public string? IdHuyen { get; set; }
        public string? IdXa { get; set; }
        public int? IdSong { get; set; }
        public int? IdLuuVuc { get; set; }
        public int? IdTieuLuuVuc { get; set; }
        public int? IdTangChuaNuoc { get; set; }
        public string? CapCT { get; set; }
        public string? CHeDoXT { get; set; }
        public string? ChuThich { get; set; }
        public string? KhoiLuongCacHangMucTD { get; set; }
        public double? MaCT { get; set; }
        public double? MucDichhKT { get; set; }
        public string? MucDichHNK { get; set; }
        public int? MucDichhTD { get; set; }
        public string? NamBatDauVanHanh { get; set; }
        public string? NguonNuocKT { get; set; }
        public string? NguonNuocXT { get; set; }
        public string? PhuongThucKT { get; set; }
        public string? PhuongThucXT { get; set; }
        public string? QKTThietKe { get; set; }
        public string? QKTThucTe { get; set; }
        public string? QuyMoHNK { get; set; }
        public string? SoLuongGieng { get; set; }
        public string? SoLuongGiengKT { get; set; }
        public string? SoLuongGiengQT { get; set; }
        public string? TaiKhoan { get; set; }
        public int? TenCT { get; set; }
        public int? ThoiGianHNK { get; set; }
        public string? ThoiGianKT { get; set; }
        public int? ThoiGianXD { get; set; }
        public int? ViTriCT { get; set; }
        public int? ViTriXT { get; set; }
        public int? X { get; set; }
        public string? Y { get; set; }
        public bool? DaXoa { get; set; }

        public CT_LoaiDto? loaiCT { get; set; }
        public List<CT_HangMucDto>? hangmuc { get; set; }
        public CT_ThongSoDto? thongso { get; set; }
        public DonViHCDto? donvi_hanhchinh { get; set; }
        public List<GP_ThongTinDto>? giayphep { get; set; }
        public List<LuuLuongTheoMucDichDto>? luuluongtheo_mucdich { get; set; }

    }
}
