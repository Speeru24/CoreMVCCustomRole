using System;
using System.Collections.Generic;

namespace CoreMVC.Models.DB
{
    public partial class HospitalRoles
    {
        public int HospitalRoleId { get; set; }
        public string RoleName { get; set; }
        public int? HospitalId { get; set; }

        public virtual Hospitals Hospital { get; set; }
    }
}
