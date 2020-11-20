using CoreApplication2.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApplication2.Models
{
    public class RegEvent
    {
        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; } //Ref. navigation property ApplicationUser(Student)

        [Required]
        public int EventId { get; set; }
        public ClgEvent Event { get; set; } // Ref. navigation property ClgEvent
    }
}
