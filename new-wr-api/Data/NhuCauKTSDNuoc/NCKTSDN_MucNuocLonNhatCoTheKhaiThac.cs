using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using new_wr_api.Dto;

namespace new_wr_api.Data
{
    public class NCKTSDN_MucNuocLonNhatCoTheKhaiThac
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaMucNuocLonNhatCoTheKhaiThac { get; set; }
        public string? SoHieuLoKhoan { get; set; }
        public string? ViTriKhaiThac { get; set; }
        public double? ChieuSauLoKhoan { get; set; }
        public double? MucNuocTinh { get; set; }
        public double? GioiHanChieuSauMucNuocKhaiThac { get; set; }
        public double? ChieuSauMucNuocLonNhatKhaiThac { get; set; }
    }
}
