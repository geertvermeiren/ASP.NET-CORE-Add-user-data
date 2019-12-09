using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebApp1.Areas.Identity.Data
{
    public class Adress:IdentityUser
    {
        public string Country { get; set; }
    }
}
