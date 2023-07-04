using AutoMapper;
using new_wr_api.Data;
using new_wr_api.Models;

namespace new_wr_api.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {

            //Authenticatiion
            CreateMap<AspNetUsers, UserModel>().ReverseMap();
            CreateMap<AspNetRoles, RoleModel>().ReverseMap();

            //Other mapper
            CreateMap<Dashboards, DashboardModel>().ReverseMap();
            CreateMap<Permissions, PermissionModel>().ReverseMap();
            CreateMap<Constructions, ConstructionModel>().ReverseMap();
        }
    }
}
