using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Assignment_EAP.Models
{
    public class Assignment_EAPContext : DbContext
    {
        public Assignment_EAPContext() : base("name=EAP_AssignmentContext")
        {
        }

        public System.Data.Entity.DbSet<Assignment_EAP.Models.Market> Markets { get; set; }

        public System.Data.Entity.DbSet<Assignment_EAP.Models.Coin> Coins { get; set; }
    }
}