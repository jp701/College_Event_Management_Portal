using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApplication2.Models
{
    public class EventProgram
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="Program Name")]
        public string Title { get; set; }

        [Required]
        public Cate? Type { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Venue { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public DateTime EndTime { get; set; }

        public int EventId { get; set; } // foreign key

        public ClgEvent ClgEvent { get; set; } // Ref. navigation property
    }
}
