namespace new_wr_api.Data.Dto
{
    public class DashboardDto : Dashboard
    {
        public DashboardDto()
        { }

        public DashboardDto(Dashboard item)
        {
            this.Id = item.Id;
            this.Name = item.Name;
            this.Path = item.Path;
            this.Description = item.Description;
        }

        public Dashboard ToDashboard()
        {
            Dashboard res = new Dashboard
            {
                Id = this.Id,
                Name = this.Name,
                Path = this.Path,
                Description = this.Description,
            };
            return res;
        }
    }
}