using System;
using System.Collections.Generic;

namespace CoreMVC.Models.DB
{
    public partial class FacilityPermission
    {
        public int FacilityPermissionId { get; set; }
        public string PermissionName { get; set; }
        public int? FacilityId { get; set; }

        public virtual Facilities Facility { get; set; }
    }
}
