using AutoMapper;
using new_wr_api.Data;
using new_wr_api.Models;
using new_wr_api.Models.Authenticate;

namespace new_wr_api.Helpers
{
    public class MapperConfigure : Profile
    {
        public MapperConfigure()
        {

            //Authenticatiion
            CreateMap<AspNetUsers, UserModel>().ReverseMap();
            CreateMap<AspNetUsers, UserInfoModel>().ForMember(dest => dest.Dashboards, opt =>
                {
                    opt.MapFrom((src, dest) => dest.Dashboards);
                }).ReverseMap();
            CreateMap<AspNetRoles, RoleModel>()
                .ForMember(dest => dest.Dashboards, opt =>
                {
                    opt.MapFrom((src, dest) => dest.Dashboards);
                }).ReverseMap();
            CreateMap<Dashboards, DashboardModel>()
                .ForMember(dest => dest.Functions, opt =>
                {
                    opt.MapFrom((src, dest) => dest.Functions);
                }).ReverseMap();
            CreateMap<Permissions, PermissionModel>().ReverseMap();
            CreateMap<UserDashboards, UserDashboardModel>().ReverseMap();
            CreateMap<RoleDashboards, RoleDashboardModel>().ReverseMap();
            CreateMap<Functions, FunctionModel>().ReverseMap();

            //Other mapper

            CreateMap<Business, BusinessModel>().ReverseMap();
            CreateMap<Constructions, ConstructionModel>().ReverseMap();
            CreateMap<Licenses, LicenseModel>()
                .ForMember(cons => cons.Constructions, opt =>
                {
                    opt.MapFrom((src, cons) => cons.Constructions);
                })
                .ForMember(bus => bus.Business, opt =>
                {
                    opt.MapFrom((src, bus) => bus.Business);
                })
                .ReverseMap();
        }
    }
}
