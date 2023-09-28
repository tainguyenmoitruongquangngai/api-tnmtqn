using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace new_wr_api.Data
{
    public class Notification
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? NotifyContent { get; set; }
        public string? Url { get; set; }
        public string? NotifyTitle { get; set; }
        public DateTime? Time { get; set; }
        public bool IsError { get; set; }
    }
}
