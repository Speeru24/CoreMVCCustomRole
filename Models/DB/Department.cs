using System;
using System.Collections.Generic;

namespace CoreMVC.Models.DB
{
    public partial class Department
    {
        public Department()
        {
            DepartmentPermission = new HashSet<DepartmentPermission>();
            DepartmentRoles = new HashSet<DepartmentRoles>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int? FacilityId { get; set; }

        public virtual Facilities Facility { get; set; }
        public virtual ICollection<DepartmentPermission> DepartmentPermission { get; set; }
        public virtual ICollection<DepartmentRoles> DepartmentRoles { get; set; }
    }
}
