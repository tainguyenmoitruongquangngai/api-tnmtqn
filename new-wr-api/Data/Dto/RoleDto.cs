namespace new_wr_api.Data.Dto
{
    public class RoleDto : ApplicationRole
    {
        public RoleDto()
        { }

        public RoleDto(ApplicationRole item)
        {
            Id = item.Id;
            Name = item.Name;
            IsDefault = item.IsDefault;
        }

        public RoleDto ToRoleDto()
        {
            RoleDto res = new RoleDto
            {
                Id = this.Id,
                Name = this.Name,
                IsDefault = this.IsDefault,
            };
            return res;
        }
    }
}
