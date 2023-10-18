using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace new_wr_api.Data
{
    public class ThoiGianVanHanhCongTrinh

    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaNamVanHanh { get; set; }
        public int? NamBatDauVanHanh { get; set; }
    }
}
