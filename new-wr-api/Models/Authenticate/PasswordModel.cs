namespace new_wr_api.Models
{
    public class ChangePasswordModel
    {
        public string? currentPassword { get; set; }
        public string? newPassword { get; set; }
        public string? newConfirmPassword { get; set; }
    }

    public class SetPasswordModel
    {
        public UserModel? user { get; set; }
        public string? newPassword { get; set; }
    }
}
