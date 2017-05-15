using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Web;

namespace NerdSolo.Models
{
    public class Dinner
    {
        public int DinnerID { get; set; }
        public string Title { get; set; }
        public DateTime EventDate { get; set; }
        public string Address { get; set; }
        public string HostedBy { get; set; }

        public virtual ICollection<RSVP> RSVPs { get; set; }


    }
}