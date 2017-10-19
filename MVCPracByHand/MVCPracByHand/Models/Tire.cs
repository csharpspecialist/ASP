using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MVCPracByHand.Models
{
    public class Tire
    {

        public int ID { get; set; }
        [Display (Name ="Tire Width")]
        public int TireWidth { get; set; }
        public int Ratio { get; set; }
        [Display(Name = "Rim Size")]
        public int Diameter { get; set; }
        public string Manufacturer { get; set; }
        public string Location { get; set; }
        public int Price { get; set; }
        [Display(Name = "Number In Stock")]
        public int NumberInStock { get; set; }
    }

    public class TireDBContext : DbContext
    {

        public DbSet<Tire> Wheels { get; set; }


    }





}
