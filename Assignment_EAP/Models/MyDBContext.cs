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
    }
}