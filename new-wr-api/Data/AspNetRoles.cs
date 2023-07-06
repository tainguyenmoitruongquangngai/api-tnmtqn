﻿using Microsoft.AspNetCore.Identity;

namespace new_wr_api.Data
{
    public class AspNetRoles : IdentityRole
    {
        public Nullable<bool> IsDefault { get; set; }
        public string? Discriminator { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public string? ModifiedUser { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<bool> IsDeleted { get; set; }

    }
}
