namespace new_wr_api.Data.Dto
{
    public class PermissionDto : Permission
    {
        public PermissionDto()
        { }

        public PermissionDto(Permission item)
        {
            this.Id = item.Id;
            this.UserName = item.UserName;
            this.UserId = item.UserId;
            this.RoleId = item.RoleId;
            this.RoleName = item.RoleName;
            this.DashboardId = item.DashboardId;
            this.PermitName = item.PermitName;
            this.PermitCode = item.PermitCode;
        }

        public Permission ToPermission()
        {
            Permission res = new Permission
            {
                Id = this.Id,
                UserName = this.UserName,
                UserId = this.UserId,
                RoleId = this.RoleId,
                RoleName = this.RoleName,
                DashboardId = this.DashboardId,
                PermitName = this.PermitName,
                PermitCode = this.PermitCode,
            };
            return res;
        }
    }
}