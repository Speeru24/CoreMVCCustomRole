using System;
using System.Collections.Generic;

namespace CoreMVC.Models.DB
{
    public partial class ContractingEntitiesRoles
    {
        public int CeRoleId { get; set; }
        public string RoleName { get; set; }
        public int? CeId { get; set; }

        public virtual ContractingEntities Ce { get; set; }
    }
}
