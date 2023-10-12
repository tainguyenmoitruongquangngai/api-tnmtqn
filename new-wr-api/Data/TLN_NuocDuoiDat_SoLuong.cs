using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace new_wr_api.Data
{
    public class TLN_NuocDuoiDat_SoLuong
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? IdTangChuaNuoc { get; set; }
        public double? DienTichPhanBo { get; set; }
        public double? ChieuSauPhanBoTu { get; set; }
        public double? ChieuSauPhanBoDen { get; set; }
        public double? HmaxKyTruoc { get; set; }
        public double? HmaxBaoCao { get; set; }
        public double? HmaxThayDoi { get; set; }
        public double? HTBKyTruoc { get; set; }
        public double? HTBBaoCao { get; set; }
        public double? HTBThayDoi { get; set; }
        public double? HminKyTruoc { get; set; }
        public double? HminBaoCao { get; set; }
        public double? HminThayDoi { get; set; }
        public string? GhiChu { get; set; }
    }
}
