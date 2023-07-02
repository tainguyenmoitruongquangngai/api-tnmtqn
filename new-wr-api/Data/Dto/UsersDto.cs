namespace new_wr_api.Data.Dto
{
    public class UsersDto : ApplicationUser
    {
        public List<RoleDto>? Roles { get; set; }

        public UsersDto()
        {
            Roles = new List<RoleDto>();
        }

        public UsersDto(ApplicationUser item)
        {
            if (item == null)
            {
                return;
            }
            this.Id = item.Id;
            this.UserName = item.UserName;
            this.FullName = item.FullName;
            this.Email = item.Email;
            this.PhoneNumber = item.PhoneNumber;
            this.Roles = new List<RoleDto>();
        }

        public ApplicationUser ToApplicationUser()
        {
            ApplicationUser ret = new ApplicationUser
            {
                Id = this.Id,
                UserName = this.UserName,
                PasswordHash = this.PasswordHash,
                FullName = this.FullName,
                Email = this.Email,
                PhoneNumber = this.PhoneNumber,
            };
            return ret;
        }
    }
}
