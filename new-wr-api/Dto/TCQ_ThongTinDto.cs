namespace new_wr_api.Dto
{
    public class TCQ_ThongTinDto
    {
        public int? Id { get; set; }
        public int? IdCon { get; set; }
        public string? SoQDTCQ { get; set; }
        public DateTime? NgayKy { get; set; }
        public string? CoQuanCP { get; set; }
        public double? TongTienCQ { get; set; }
        public string? FilePDF { get; set; }
        public string? GhiChu { get; set; }
        public bool? DaXoa { get; set; }

        public TCQ_ThongTinDto? qd_bosung { get; set; }
    }
}
