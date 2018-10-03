using System;
using System.Collections.Generic;

namespace CoreMVC.Models.DB
{
    public partial class HospitalPermission
    {
        public int HospitalPermissionId { get; set; }
        public string PermissionName { get; set; }
        public int? HospitalId { get; set; }

        public virtual Hospitals Hospital { get; set; }
    }
}
