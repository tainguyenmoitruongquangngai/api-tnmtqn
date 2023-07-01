using AutoMapper;
using new_wr_api.Data;
using new_wr_api.Models;

namespace new_wr_api.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Construction, ConstructionModel>().ReverseMap();
            CreateMap<License, LicenseModel>().ReverseMap();
            CreateMap<Dashboard, DashboardModel>().ReverseMap();
            CreateMap<Permission, PermissionModel>().ReverseMap();
        }
    }
}
