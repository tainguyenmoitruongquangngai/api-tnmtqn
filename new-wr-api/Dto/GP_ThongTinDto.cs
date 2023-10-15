using new_wr_api.Data;

namespace new_wr_api.Dto
{
    public class GP_ThongTinDto
    {
        public int Id { get; set; }
        public int? IdCon { get; set; }
        public int? IdLoaiGP { get; set; }
        public int? IdTCCN { get; set; }
        public int? IdCT { get; set; }
        public string? TenGP { get; set; }
        public string? SoGP { get; set; }
        public DateTime? NgayKy { get; set; }
        public DateTime? NgayCoHieuLuc { get; set; }
        public DateTime? NgayHetHieuLuc { get; set; }
        public string? ThoiHan { get; set; }
        public string? CoQuanCapPhep { get; set; }
        public string? FileGiayPhep { get; set; }
        public string? FileGiayToLienQuan { get; set; }
        public string? FileDonXinCP { get; set; }
        public bool? DaBiThuHoi { get; set; }
        public bool? DaXoa { get; set; }

        public string? hieuluc_gp
        {
            get
            {
                if (DaBiThuHoi == true)
                {
                    return "da-bi-thu-hoi";
                }
                else if (NgayHetHieuLuc.HasValue)
                {
                    DateTime ngayhethan = NgayHetHieuLuc.Value;
                    if (ngayhethan >= DateTime.Today && ngayhethan < DateTime.Today.AddDays(160))
                    {
                        return "sap-het-hieu-luc";
                    }
                    else if (ngayhethan < DateTime.Today)
                    {
                        return "het-hieu-luc";
                    }
                    else if (ngayhethan > DateTime.Today.AddDays(160))
                    {
                        return "con-hieu-luc";
                    }
                }
                return "con-hieu-luc";
            }
        }

        public GP_LoaiDto? loaiGP { get; set; }
        public TangChuaNuocDto? tangchuanuoc { get; set; }
        public CT_ThongTinDto? congtrinh { get; set; }
        public ToChuc_CaNhanDto? tochuc_canhan { get; set; }
        public List<GP_TCQDto>? gp_tcq { get; set; }
        public List<TCQ_ThongTinDto>? tiencq { get; set; }
    }

    public class CountDataDto
    {
        public int Total { get; set; } = 0;
        public int Btnmt { get; set; } = 0;
        public int Ubndt { get; set; } = 0;
    }
}
