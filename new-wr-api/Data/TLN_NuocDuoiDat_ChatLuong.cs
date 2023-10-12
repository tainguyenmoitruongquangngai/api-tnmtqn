using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace new_wr_api.Data
{
    public class TLN_NuocDuoiDat_ChatLuong
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double? pHMax { get; set; }
        public double? pHMin { get; set; }
        public double? PHAvg { get; set; }
        public double? DoCungMax { get; set; }
        public double? DoCungMin { get; set; }
        public double? DoCungAvg { get; set; }
        public double? NitratMax { get; set; }
        public double? NitratMin { get; set; }
        public double? NitratAvg { get; set; }
        public double? SulfatMax { get; set; }
        public double? SulfatMin { get; set; }
        public double? SulfatAvg { get; set; }
        public double? AsenMax { get; set; }
        public double? AsenMin { get; set; }
        public double? AsenAvg { get; set; }
    }
}
