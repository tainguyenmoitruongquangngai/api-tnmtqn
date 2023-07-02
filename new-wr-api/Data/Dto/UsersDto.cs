using new_wr_api.Data;
using new_wr_api.Data.Dto;

public class UsersDto : ApplicationUser
{
    public List<RoleDto>? Roles { get; set; }

    public UsersDto()
    { }

    public UsersDto(ApplicationUser item)
    {
        Id = item.Id;
        UserName = item.UserName;
        PasswordHash = item.PasswordHash;
        FullName = item.FullName;
        Email = item.Email;
        PhoneNumber = item.PhoneNumber;
    }

    public UsersDto ToUsersDto()
    {
        UsersDto res = new UsersDto
        {
            Id = this.Id,
            UserName = this.UserName,
            FullName = this.FullName,
            Email = this.Email,
            PhoneNumber = this.PhoneNumber,
        };
        return res;
    }
}
