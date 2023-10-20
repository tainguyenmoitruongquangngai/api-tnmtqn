using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace new_wr_api.Data
{
    public class TLN_CongTrinh
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaCT { get; set; }
        public int? MaTangChuaNuoc { get; set; }
        public string? TenCT { get; set; }
        public string? KyHieuCT { get; set; }
        public string? DiaChiCT { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }

        [ForeignKey("MaTangChuaNuoc ")]
        public virtual TLN_TangChuaNuoc? TLN_TangChuaNuoc { get; set; }

        public virtual ThongTinVeMucNuocTinh? ThongTinVeMucNuocTinh { get; set; }
        public virtual ThongTinVeTruLuongNuoc? ThongTinVeTruLuongNuoc { get; set; }
        public virtual ThongTinVeChatLuongNuoc? ThongTinVeChatLuongNuoc { get; set; }
        public virtual ThongTinVeHoatDongCuaCongTrinh? ThongTinVeHoatDongCuaCongTrinh { get; set; }

    }
}
