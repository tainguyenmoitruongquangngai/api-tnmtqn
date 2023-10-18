using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace new_wr_api.Data
{
    public class CheDoKhaiThacCongTrinh
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaCheDoKhaiThacCongTrinh { get; set; }
        public int? MaThongTinCongTrinh { get; set; }
        public string? CheDoKhaiThac { get; set; }
    }
}
