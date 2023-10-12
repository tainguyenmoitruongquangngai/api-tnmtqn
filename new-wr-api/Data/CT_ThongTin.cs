using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace new_wr_api.Data
{
    public class CT_ThongTin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int IdLoaiCT { get; set; }
        public string? IdHuyen { get; set; }
        public string? IdXa { get; set; }
        public int? IdSong { get; set; }
        public int? IdLuuVuc { get; set; }
        public int? IdTieuLuuVuc { get; set; }
        public int? IdTangChuaNuoc { get; set; }
        public string? TaiKhoan { get; set; }
        public string? TenCT { get; set; }
        public string? MaCT { get; set; }
        public string? ViTriCT { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }
        public int? NamBatDauVanHanh { get; set; }
        public string? NguonNuocKT { get; set; }
        public string? CheDoKT { get; set; }
        public string? MucDichhKT { get; set; }
        public string? PhuongThucKT { get; set; }
        public string? PhuongThucXT { get; set; }
        public string? CHeDoXT { get; set; }
        public string? NguonNuocXT { get; set; }
        public string? ThoiGianKT { get; set; }
        public string? ThoiGianHNK { get; set; }
        public string? MucDichHNK { get; set; }
        public string? MucDichhTD { get; set; }
        public string? QuyMoHNK { get; set; }
        public string? ThoiGianXD { get; set; }
        public int? SoLuongGiengKT { get; set; }
        public int? SoLuongGiengQT { get; set; }
        public string? ChuThich { get; set; }
        public int? SoLuongGieng { get; set; }
        public int? KhoiLuongCacHangMucTD { get; set; }
        public int? QKTThietKe { get; set; }
        public int? QKTThucTe { get; set; }
        public string? ViTriXT { get; set; }
        public double? QXaMaxTT { get; set; }
        public double? DungTichTT { get; set; }
        public double? HHaLuuTT { get; set; }
        public double? HThuongLuuTT { get; set; }
        public double? QMinTT { get; set; }
        public double? QMaxTT { get; set; }
        public double? ThoiGianTT { get; set; }
        public int? MatKetNoi { get; set; }
        public int? Loi { get; set; }
        public DateTime? ThoiGianTao { get; set; }
        public string? TaiKhoanTao { get; set; }
        public DateTime? ThoiGianSua { get; set; }
        public string? TaiKhoanSua { get; set; }
        public bool? DaXoa { get; set; }

        // Navigation property to represent the relationship
        [ForeignKey("IdLoaiCT")]
        public virtual CT_Loai? LoaiCT { get; set; }
        public virtual CT_ThongSo? ThongSo { get; set; }
        public virtual ICollection<CT_HangMuc>? HangMuc { get; set; }
        public virtual ICollection<GP_ThongTin>? GiayPhep { get; set; }


        [ForeignKey("IdTangChuaNuoc")]
        public virtual TangChuaNuoc? TangChuaNuoc { get; set; }
    }
}
