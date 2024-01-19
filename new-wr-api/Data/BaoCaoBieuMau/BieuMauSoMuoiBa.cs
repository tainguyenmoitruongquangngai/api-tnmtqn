using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace new_wr_api.Data
{
    public class BieuMauSoMuoiBa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? ViTriQuanTrac { get; set; }
        public double? BOD5LonNhat { get; set; }
        public double? BOD5NhoNhat { get; set; }
        public double? CODLonNhat { get; set; }
        public double? CODNhoNhat { get; set; }
        public double? DOLonNhat { get; set; }
        public double? DONhoNhat { get; set; }
        public string? GhiChu { get; set; }
    }
}
