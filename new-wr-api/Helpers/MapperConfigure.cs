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

            //Business
            CreateMap<Business, BusinessModel>().ReverseMap();

            //Constructions
            CreateMap<Constructions, ConstructionModel>().ReverseMap();

            //Licenses
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

            //LicenseFees
            CreateMap<LicenseFees, LicenseFeeModel>().ReverseMap();
        }
    }
}
