using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using new_wr_api.Dto;

namespace new_wr_api.Data
{
    public class LuuLuongTheoMucDich
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? IdCT { get; set; }
        public string? MucDich { get; set; }
        public double? LuuLuong { get; set; }
        public string? DonViDo { get; set; }
        public string? GhiChu { get; set; }
        public bool? DaXoa { get; set; }

        [ForeignKey("IdCT")]
        public CT_ThongTin? CT_ThongTin { get; set; }
    }
}
