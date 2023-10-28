using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace new_wr_api.Data
{
    public class CacCapBaoDongMucNuocLu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? MaCacCapBaoDongMucNuocLu { get; set; }
        public int? MaCongTrinhHoChua { get; set; }
        public string? TenSong { get; set; }
        public string? TenTramThuyVan { get; set; }
        public double? MucNuocTuongUngVoiCapBaoDong1 { get; set; }
        public double? MucNuocTuongUngVoiCapBaoDong2 { get; set; }
        public double? MucNuocTuongUngVoiCapBaoDong3 { get; set; }


        //tạo  khoá ngoại
        [ForeignKey("MaCongTrinhHoChua")]
        public virtual CongTrinhHoChua? CongTrinhHoChua { get; set; }
    }
}
