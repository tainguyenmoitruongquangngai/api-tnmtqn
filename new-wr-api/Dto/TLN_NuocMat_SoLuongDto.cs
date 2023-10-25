namespace new_wr_api.Dto
{
    public class TLN_NuocMat_SoLuongDto
    {
        public int Id { get; set; }
        public int? IdSong { get; set; }
        public string? ChayRa { get; set; }
        public double? ChieuDai { get; set; }
        public SongDto? Song { get; set; }
    }
}
