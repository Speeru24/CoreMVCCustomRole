using System;
using System.Collections.Generic;

namespace CoreMVC.Models.DB
{
    public partial class DepartmentRoles
    {
        public int DepartmentRoleId { get; set; }
        public string RoleName { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Department Department { get; set; }
    }
}
