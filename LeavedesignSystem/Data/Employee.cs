using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeavedesignSystem.Data
{
    public class Employee:IdentityUser
    {
        public string Firstname { get; set; }
        public string TaxId { get; set; }

        public string Lastname { get; set; }

        public DateTime DayeofBirth { get; set; }

        public DateTime DateJoined { get; set; }

        
    }
}
