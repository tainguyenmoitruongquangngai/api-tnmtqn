using AutoMapper;
using new_wr_api.Data;
using new_wr_api.Dto;
using new_wr_api.Models;
using new_wr_api.Models.Authenticate;

namespace new_wr_api.Helpers
{
    public class MapperConfigure : Profile
    {
        public MapperConfigure()
        {

            //-------------Authenticatiion--------------------

            //Users
            CreateMap<AspNetUsers, UserModel>().ReverseMap();

            //Users Info
            CreateMap<AspNetUsers, UserInfoModel>().ForMember(dest => dest.Dashboards, opt =>
                {
                    opt.MapFrom((src, dest) => dest.Dashboards);
                }).ReverseMap();

            //Roles
            CreateMap<AspNetRoles, RoleModel>()
                .ForMember(dest => dest.Dashboards, opt =>
                {
                    opt.MapFrom((src, dest) => dest.Dashboards);
                }).ReverseMap();

            //Dashboards
            CreateMap<Dashboards, DashboardModel>()
                .ForMember(dest => dest.Functions, opt =>
                {
                    opt.MapFrom((src, dest) => dest.Functions);
                }).ReverseMap();

            //Permissions
            CreateMap<Permissions, PermissionModel>().ReverseMap();

            //Dashboard for Roles and Users
            CreateMap<UserDashboards, UserDashboardModel>().ReverseMap();
            CreateMap<RoleDashboards, RoleDashboardModel>().ReverseMap();

            //functions
            CreateMap<Functions, FunctionModel>().ReverseMap();

            //-------------Other mapper--------------------

            CreateMap<CT_Loai, CT_LoaiDto>().ReverseMap();
            CreateMap<CT_HangMuc, CT_HangMucDto>().ReverseMap();
            CreateMap<CT_ThongSo, CT_ThongSoDto>().ReverseMap();
            CreateMap<CT_ThongTin, CT_ThongTinDto>()
                .ForMember(dest => dest.loaiCT, opt => opt.MapFrom(src => src.LoaiCT))
                .ForMember(dest => dest.hangmuc, opt => opt.MapFrom(src => src.HangMuc))
                .ForMember(dest => dest.thongso, opt => opt.MapFrom(src => src.ThongSo))
                .ForMember(dest => dest.donvi_hanhchinh, opt => opt.MapFrom((src, dest) => dest.donvi_hanhchinh))
                .ForMember(dest => dest.giayphep, opt => opt.MapFrom(src => src.GiayPhep))
            .ReverseMap();

            CreateMap<DonViHC, DonViHCDto>().ReverseMap();

            CreateMap<GP_Loai, GP_LoaiDto>().ReverseMap();
            CreateMap<GP_ThongTin, GP_ThongTinDto>()
                .ForMember(dest => dest.tochuc_canhan, opt => opt.MapFrom(src => src.ToChuc_CaNhan))
                .ForMember(dest => dest.loaiGP, opt => opt.MapFrom(src => src.LoaiGP))
                .ForMember(dest => dest.congtrinh, opt => opt.MapFrom(src => src.CongTrinh))
                .ForMember(dest => dest.gp_tcq, opt => opt.MapFrom(src => src.GP_TCQ))
                .ForMember(dest => dest.tiencq, opt => opt.MapFrom((src, dest) => dest.tiencq));

            CreateMap<GP_TCQ, GP_TCQDto>();
            CreateMap<TCQ_ThongTin, TCQ_ThongTinDto>();

            CreateMap<ToChuc_CaNhan, ToChuc_CaNhanDto>().ReverseMap();



            //baocaobieumau
            CreateMap<BieuMauSoMot, BieuMauMotDto>().ReverseMap();
            CreateMap<BieuMauSoHai, BieuMauHaiDto>().ReverseMap();
            CreateMap<BieuMauSoBa, BieuMauBaDto>().ReverseMap();
            CreateMap<BieuMauSoBon, BieuMauBonDto>().ReverseMap();
            CreateMap<BieuMauSoNam, BieuMauNamDto>().ReverseMap();


            //TruLuongNuoc
            CreateMap<Tram_ThongTin, Tram_ThongTinDto>().ReverseMap();
            CreateMap<TLN_NuocMua_TongLuong, TLN_NuocMua_TongLuongDto>().ReverseMap();

        }
    }
}
