using System;
using System.Collections.Generic;

namespace CoreMVC.Models.DB
{
    public partial class FacilityRoles
    {
        public int FacilityRoleId { get; set; }
        public string RoleName { get; set; }
        public int? FacilityId { get; set; }

        public virtual Facilities Facility { get; set; }
    }
}
