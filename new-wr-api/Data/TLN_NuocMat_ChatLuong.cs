using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace new_wr_api.Data
{
    public class TLN_NuocMat_ChatLuong
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? IdXa { get; set; }
        public int? IdHuyen { get; set; }
        public int? IdTinh { get; set; }
        public int? IdLuuVucSong { get; set; }
        public int? GiaTriWQI { get; set; }
        public DateTime? ThoiGian { get; set; }
    }
}
