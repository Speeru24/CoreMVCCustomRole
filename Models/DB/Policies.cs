using System;
using System.Collections.Generic;

namespace CoreMVC.Models.DB
{
    public partial class Policies
    {
        public Policies()
        {
            ContractingEntities = new HashSet<ContractingEntities>();
        }

        public int PolicyId { get; set; }
        public string PolicyName { get; set; }
        public int RegId { get; set; }

        public virtual Registration Reg { get; set; }
        public virtual ICollection<ContractingEntities> ContractingEntities { get; set; }
    }
}
