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
            CreateMap<ApplicationUser, UserModel>().ReverseMap();
            CreateMap<ApplicationRole, RoleModel>().ReverseMap();

            //Other mapper
            CreateMap<Dashboard, DashboardModel>().ReverseMap();
            CreateMap<Permission, PermissionModel>().ReverseMap();
            CreateMap<Construction, ConstructionModel>().ReverseMap();
        }
    }
}
