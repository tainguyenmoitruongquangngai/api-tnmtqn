using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace new_wr_api.Data
{
    public class TongLuongNuocMan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaTongLuongNuocMan { get; set; }
        public int? MaTangChuaNuoc { get; set; }
        public double? DienTichPhanBoCuaNuocMan { get; set; }
        public double? TruLuongNuocMan { get; set; }
        public double? ChieuSauPhanBoTu { get; set; }
        public double? ChieuSauPhanBoDen { get; set; }
        public string? GhiChu { get; set; }
        //tạo  khoá ngoại
        [ForeignKey("MaTangChuaNuoc ")]
        public virtual TLN_TangChuaNuoc? TLN_TangChuaNuoc { get; set; }
    }
}
