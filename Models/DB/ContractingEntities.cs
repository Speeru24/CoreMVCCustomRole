using System;
using System.Collections.Generic;

namespace CoreMVC.Models.DB
{
    public partial class ContractingEntities
    {
        public ContractingEntities()
        {
            ContractingEntitiesPermission = new HashSet<ContractingEntitiesPermission>();
            ContractingEntitiesRoles = new HashSet<ContractingEntitiesRoles>();
            Hospitals = new HashSet<Hospitals>();
        }

        public int CeId { get; set; }
        public string CeName { get; set; }
        public int PolicyId { get; set; }

        public virtual Policies Policy { get; set; }
        public virtual ICollection<ContractingEntitiesPermission> ContractingEntitiesPermission { get; set; }
        public virtual ICollection<ContractingEntitiesRoles> ContractingEntitiesRoles { get; set; }
        public virtual ICollection<Hospitals> Hospitals { get; set; }
    }
}
