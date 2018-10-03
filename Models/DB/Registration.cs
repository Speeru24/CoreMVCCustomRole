using System;
using System.Collections.Generic;

namespace CoreMVC.Models.DB
{
    public partial class Registration
    {
        public Registration()
        {
            Policies = new HashSet<Policies>();
        }

        public int RegId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Policies> Policies { get; set; }
    }
}
