﻿namespace new_wr_api.Models
{
    public class UserModel
    {
        public string? Id { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Role { get; set; }
        public List<PermissionModel>? Permission { get; set; } = null;
    }

    public class UserInfoModel
    {
        public string? Id { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Role { get; set; }
        public List<DashboardModel>? Dashboards { get; set; }
    }
}
