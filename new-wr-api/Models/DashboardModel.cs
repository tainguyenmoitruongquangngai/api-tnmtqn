using AutoMapper;
using Microsoft.EntityFrameworkCore;
using new_wr_api.Data;
using System.Collections.Generic;

namespace new_wr_api.Models
{
    public class DashboardModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Path { get; set; }
        public string? Description { get; set; }
        public bool PermitAccess { get; set; } = false;
        public virtual List<FunctionModel>? Functions { get; set; }
    }
}
