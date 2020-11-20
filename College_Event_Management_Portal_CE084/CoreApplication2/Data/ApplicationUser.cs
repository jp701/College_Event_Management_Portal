using CoreApplication2.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApplication2.Data
{
    public class ApplicationUser: IdentityUser
    {
        // Additional fields for Student
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public IList<RegEvent> RegEvents { get; set; } //Collection Nav. Property
    }
}
