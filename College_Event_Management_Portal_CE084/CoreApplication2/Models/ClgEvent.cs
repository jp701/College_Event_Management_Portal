using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApplication2.Models
{
    public class ClgEvent
    {
        public int Id { get; set; }

        [Required]
        [Display(Name="Event Name")]
        public string Title { get; set; }

        [Required]
        public Cate? Category { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        public status Status { get; set; } // 0 means new & 1 corresponds to event done(old).

        [DataType(DataType.Text)]
        public string Venue { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string PhotoPath { get; set; }

        /* Collection Nav. Properties */
        public ICollection<EventProgram> EventPrograms { get; set; }

        public IList<RegEvent> RegEvents { get; set; }
    }

    public enum Cate
    {
        Cultural,Technical,Sports,Seminar,Meeting,Party,Workshop,Other
    }

    public enum status
    {
        New, //value 0 => new event
        Done //value 1 => Done event
    }
}
