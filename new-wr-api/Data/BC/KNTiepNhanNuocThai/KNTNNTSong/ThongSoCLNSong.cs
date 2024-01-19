using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using new_wr_api.Dto;

namespace new_wr_api.Data
{
    public class ThongSoCLNSong
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double? pH { get; set; }
        public double? BOD { get; set; }
        public double? COD { get; set; }
        public double? TOC { get; set; }
        public double? TSS { get; set; }
        public double? DO { get; set; }
        public double? TongPhosphor { get; set; }
        public double? TongNito { get; set; }
        public double? TongColiform { get; set; }
        public double? ColiformChiuNhiet { get; set; }
        public double? Amoni { get; set; }
        public string? MucPLCLNuoc { get; set; }
        public string? TaiKhoanTao { get; set; }
        public DateTime? ThoiGianSua { get; set; }
        public string? TaiKhoanSua { get; set; }
        public bool? DaXoa { get; set; }
    }
}
