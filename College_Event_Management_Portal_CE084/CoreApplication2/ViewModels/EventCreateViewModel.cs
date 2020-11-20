using CoreApplication2.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApplication2.ViewModels
{
    public class EventCreateViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Event Name")]
        public string Title { get; set; }

        [Required]
        public Cate? Category { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [EventDateValidation(ErrorMessage ="Event date should be greater than current date")] //custom date validation attribute
        public DateTime Date { get; set; }

        [Required]
        public status Status { get; set; } // 0 means new & 1 corresponds to event done(old).

        [DataType(DataType.Text)]
        public string Venue { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [DataType(DataType.Upload)]
        public IFormFile Photo { get; set; }
    }
}
