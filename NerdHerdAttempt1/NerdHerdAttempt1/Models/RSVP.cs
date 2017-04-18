using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Web;

namespace NerdHerdAttempt1.Models
{
    public class RSVP
    {
        public int RsvpID { get; set; }
        public int DinnerID { get; set; }
        public string AttendeeEmail { get; set; }
        public virtual Dinner Dinner { get; set; }
    }
}