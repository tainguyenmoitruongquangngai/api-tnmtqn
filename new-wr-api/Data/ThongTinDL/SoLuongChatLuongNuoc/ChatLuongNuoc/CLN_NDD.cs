using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace new_wr_api.Data
{
    public class CLN_NDD
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? LuuVucSong { get; set; }
        public string? SongSuoiHoChua { get; set; }
        public string? ViTriQuanTrac { get; set; }
        public double? PhMax { get; set; }
        public double? PhMin { get; set; }
        public double? ColiformMax { get; set; }
        public double? ColiformMin { get; set; }
        public double? NitrateMax { get; set; }
        public double? NitrateMin { get; set; }
        public double? AmoniMax { get; set; }
        public double? AmoniMin { get; set; }
        public double? TDSMax { get; set; }
        public double? TDSMin { get; set; }
        public double? DoCungMax { get; set; }
        public double? DoCungMin { get; set; }
        public double? ASMax { get; set; }
        public double? ASMin { get; set; }
        public double? ChlorideMax { get; set; }
        public double? ChlorideMin { get; set; }
        public string? GhiChu { get; set; }
        public DateTime? ThoiGianTao { get; set; }
        public string? TaiKhoanTao { get; set; }
        public DateTime? ThoiGianSua { get; set; }
        public string? TaiKhoanSua { get; set; }
        public bool? DaXoa { get; set; }
    }
}
