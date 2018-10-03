using System;
using System.Collections.Generic;

namespace CoreMVC.Models.DB
{
    public partial class DepartmentPermission
    {
        public int DepartmentPermissionId { get; set; }
        public string PermissionName { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Department Department { get; set; }
    }
}
