using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Assignment_EAP.Models
{
    public class Account : IdentityUser
    {
        public string FullName { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}