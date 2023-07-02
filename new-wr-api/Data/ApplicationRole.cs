﻿using Microsoft.AspNetCore.Identity;

namespace new_wr_api.Data
{
    public class ApplicationRole : IdentityRole
    {
        public bool IsDefault { get; set; }
        public string Discriminator { get; set; } = "ApplicationRole";
        public DateTime? CreatedTime { get; set; }
        public string CreatedUser { get; set; } = string.Empty;
        public DateTime? ModifiedTime { get; set; }
        public string ModifiedUser { get; set; } = string.Empty;
        public bool Status { get; set; }
        public bool IsDeleted { get; set; }

    }
}
