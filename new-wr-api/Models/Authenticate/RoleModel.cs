namespace new_wr_api.Models
{
    public class RoleModel
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public bool IsDefault { get; set; } = false;
        public virtual ICollection<DashboardModel>? Dashboards { get; set; }
    }
}
