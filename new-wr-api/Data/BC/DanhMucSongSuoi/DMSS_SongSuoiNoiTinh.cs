using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using new_wr_api.Dto;

namespace new_wr_api.Data
{
    public class DMSS_SongSuoiNoiTinh
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaSong { get; set; }
        public int? MaDiemDauSong_Suoi { get; set; }
        public int? MaDiemCuoiSong_Suoi { get; set; }
        public string? TenSongSuoi { get; set; }
        public double? ChayRa { get; set; }
        public double? ChieuDai { get; set; }
    }
}
