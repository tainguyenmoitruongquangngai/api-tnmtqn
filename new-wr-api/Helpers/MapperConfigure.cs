using AutoMapper;
using new_wr_api.Data;
using new_wr_api.Models;

namespace new_wr_api.Helpers
{
    public class MapperConfigure : Profile
    {
        public MapperConfigure()
        {

            //Authenticatiion
            CreateMap<AspNetUsers, UserModel>().ReverseMap();
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

            CreateMap<Constructions, ConstructionModel>().ReverseMap();
            CreateMap<Licenses, LicenseModel>().ReverseMap();
        }
    }
}
