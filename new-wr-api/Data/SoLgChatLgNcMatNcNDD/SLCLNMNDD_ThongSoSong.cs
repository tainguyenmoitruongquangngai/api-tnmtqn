using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using new_wr_api.Dto;

namespace new_wr_api.Data
{
    public class SLCLNMNDD_ThongSoSong
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaThongSoCuaSong { get; set; }
        public int? MaSong { get; set; }
        public double? DoDai { get; set; }
        public double? DoRongLongSong { get; set; }
        public double? DoSauMucNuoc { get; set; }
        public double? TocDoDongChay { get; set; }
        public string? DacDiemDoanSong { get; set; }
        public string? CacCongTrinhKTSDNuocMatTrenSong { get; set; }
    }
}
