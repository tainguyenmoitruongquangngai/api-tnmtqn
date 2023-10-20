using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace new_wr_api.Data
{
    public class SoLuongNDD
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaSoLuongNdd { get; set; }
        public int? MaTangChuaNuoc { get; set; }
        public double? DienTichPhanBo { get; set; }
        public double? ChieuSauPhanBoTu { get; set; }
        public double? ChieuSauPhanBoDen { get; set; }
        public string? GhiChu { get; set; }

        //tạo  khoá ngoại
        [ForeignKey("MaTangChuaNuoc ")]
        public virtual QLC_TangChuaNuoc? QLC_TangChuaNuoc { get; set; }
    }
}
