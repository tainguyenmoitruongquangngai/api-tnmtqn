namespace new_wr_api.Dto
{
    public class TLN_NuocDuoiDat_TongLuongDto
    {
        public int Id { get; set; }
        public int? IdTangChuaNuoc { get; set; }
        public float? NuocNgot_DienTichPhanBo { get; set; }
        public int? NuocNgot_IdXa { get; set; }
        public int? NuocNgot_IdHuyen { get; set; }
        public double? NuocNgot_TLTiemNang { get; set; }
        public double? NuocNgot_TLCoTheKhaiThac { get; set; }
        public double? NuocMan_DienTichPhanBo { get; set; }
        public int? NuocMan_IdXa { get; set; }
        public int? NuocMan_IdHuyen { get; set; }
        public double? NuocMan_TruLuong { get; set; }
    }
}
