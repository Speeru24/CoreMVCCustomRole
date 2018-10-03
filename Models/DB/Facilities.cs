using System;
using System.Collections.Generic;

namespace CoreMVC.Models.DB
{
    public partial class Facilities
    {
        public Facilities()
        {
            Department = new HashSet<Department>();
            FacilityPermission = new HashSet<FacilityPermission>();
            FacilityRoles = new HashSet<FacilityRoles>();
        }

        public int FacilityId { get; set; }
        public string FacilityName { get; set; }
        public int? HospitalId { get; set; }

        public virtual Hospitals Hospital { get; set; }
        public virtual ICollection<Department> Department { get; set; }
        public virtual ICollection<FacilityPermission> FacilityPermission { get; set; }
        public virtual ICollection<FacilityRoles> FacilityRoles { get; set; }
    }
}
