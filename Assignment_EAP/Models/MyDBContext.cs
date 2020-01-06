using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Assignment_EAP.Models
{
    public class MyDBContext : IdentityDbContext<Account>
    {
        public MyDBContext() : base("name=MyDBContext")
        {

        }
        public System.Data.Entity.DbSet<Assignment_EAP.Models.Market> Markets { get; set; }

        public System.Data.Entity.DbSet<Assignment_EAP.Models.Coin> Coins { get; set; }
    }
}