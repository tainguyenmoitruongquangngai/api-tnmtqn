using AutoMapper;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using System.Collections.Generic;

namespace new_wr_api.Models
{
    public class DashboardModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Path { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool PermitAccess { get; set; }
        public virtual List<FunctionModel>? Functions { get; set; }
    }
}
