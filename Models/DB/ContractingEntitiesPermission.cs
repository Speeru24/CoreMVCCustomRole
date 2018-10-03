using System;
using System.Collections.Generic;

namespace CoreMVC.Models.DB
{
    public partial class ContractingEntitiesPermission
    {
        public int CePermissionId { get; set; }
        public string PermissionName { get; set; }
        public int? CeId { get; set; }

        public virtual ContractingEntities Ce { get; set; }
    }
}
