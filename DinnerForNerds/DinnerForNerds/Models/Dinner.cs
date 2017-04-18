using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DinnerForNerds.Models
{
    public class Dinner
    {

        public int DinnerID { get; set; }

        [Required(ErrorMessage = "Please enter a Dinner Title")]
        [StringLength(20, ErrorMessage = "Title is too long..only 20 characters max!!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter the date of the Dinner...Dude!!!")]
        public DateTime EventDate { get; set; }

        [Required(ErrorMessage = "Address field cannot be blank!!..REMEMBER THAT!!!")]
        [StringLength(30, ErrorMessage = "Address is too long..only 30 characters max!!")]
        public string Address { get; set; }
        public string HostedBy { get; set; }

        public string Country { get; set; }

        public virtual ICollection<RSVP> RSVPs { get; set; }


    }

   




}