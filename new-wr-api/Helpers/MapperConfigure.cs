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

            //Basin
            CreateMap<Basins, BasinModel>().ReverseMap();

            //Constructions
            CreateMap<Constructions, ConstructionModel>()
                .ForMember(consItem => consItem.ConstructionItems, opt =>
                {
                    opt.MapFrom((src, cons) => cons.ConstructionItems);
                })
                .ForMember(lic => lic.Licenses, opt =>
                {
                    opt.MapFrom((src, cons) => cons.Licenses);
                })
                .ReverseMap();

            //ConstructionDetails 
            CreateMap<ConstructionDetails, ConstructionDetailModel>().ReverseMap();

            //ConstructionTypes
            CreateMap<ConstructionTypes, ConstructionTypesModel>().ReverseMap();

            //Licenses
            CreateMap<Licenses, LicenseModel>()
                .ForMember(cons => cons.Construction, opt =>
                {
                    opt.MapFrom((src, cons) => cons.Construction);
                })
                .ForMember(bus => bus.Business, opt =>
                {
                    opt.MapFrom((src, bus) => bus.Business);
                })
                .ForMember(licFee => licFee.LicenseFees, opt =>
                {
                    opt.MapFrom((src, licFee) => licFee.LicenseFees);
                })
                .ReverseMap();

            //LicenseFees
            CreateMap<LicenseFees, LicenseFeeModel>().ReverseMap();

            //LicenseLicenseFee
            CreateMap<LicenseLicenseFee, LicenseLicenseFeeModel>().ReverseMap();

            //LicenseTypes
            CreateMap<LicenseTypes, LicenseTypesModel>().ReverseMap();

            //Locations
            CreateMap<Locations, LocationsModel>().ReverseMap();
            CreateMap<Locations, DistrictModel>().ReverseMap();
            CreateMap<Locations, CommuneModel>().ReverseMap();

            //River
            CreateMap<Rivers, RiverModel>().ReverseMap();
        }
    }
}
