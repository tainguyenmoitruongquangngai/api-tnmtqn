namespace new_wr_api.Data.Dto
{
    public class UsersDto
    {
        public string? Id { get; set; }
        public string? UserName { get; set; } 
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? UserType { get; set; }
        public List<string>? Roles { get; set; }
    }
}
