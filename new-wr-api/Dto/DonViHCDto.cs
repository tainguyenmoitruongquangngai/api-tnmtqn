namespace new_wr_api.Dto
{
    public class DonViHCDto
    {
        public int Id { get; set; }
        public string? TenTinh { get; set; }
        public string? IdTinh { get; set; }
        public string? TenHuyen { get; set; }
        public string? IdHuyen { get; set; }
        public string? TenXa { get; set; }
        public string? IdXa { get; set; }
        public string? CapHanhChinh { get; set; }
        public bool? DaXoa { get; set; }
    }
    public class HuyenDto
    {
        public string? TenHuyen { get; set; }
        public string? IdHuyen { get; set; }
    }
    public class XaDto
    {
        public string? IdHuyen { get; set; }
        public string? TenHuyen { get; set; }
        public string? IdXa { get; set; }
        public string? TenXa { get; set; }
        public string? CapHanhChinh { get; set; }
    }
}
