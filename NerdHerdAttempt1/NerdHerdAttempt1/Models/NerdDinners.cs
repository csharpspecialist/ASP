﻿using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace NerdHerdAttempt1.Models
{
    public class NerdDinners : DbContext
    {

        public DbSet<Dinner> Dinners { get; set; }
        public DbSet<RSVP> RSVPs { get; set; }


    }
}