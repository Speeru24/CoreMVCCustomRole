using System;
using System.Collections.Generic;

namespace CoreMVC.Models.DB
{
    public partial class Hospitals
    {
        public Hospitals()
        {
            Facilities = new HashSet<Facilities>();
            HospitalPermission = new HashSet<HospitalPermission>();
            HospitalRoles = new HashSet<HospitalRoles>();
        }

        public int HospitalId { get; set; }
        public string HospitalName { get; set; }
        public int? CeId { get; set; }

        public virtual ContractingEntities Ce { get; set; }
        public virtual ICollection<Facilities> Facilities { get; set; }
        public virtual ICollection<HospitalPermission> HospitalPermission { get; set; }
        public virtual ICollection<HospitalRoles> HospitalRoles { get; set; }
    }
}
