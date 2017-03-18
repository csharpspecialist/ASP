using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Web;

namespace HelloPrac1.Models
{
    public class Info
    {
        public static List<Spud> GetPotatoInfo()
        {
            List<Spud> chip = new List<Spud> {
            new Spud { PId = 1, Type = "Salad", Texture = "Smooth" },
            new Spud { PId = 2, Type = "Russet", Texture = "Creamy" },
            new Spud { PId = 3, Type = "Mashed", Texture = "Delicious" }

            };

            return chip;
        }
    }




        public class Spud
    {
        public int PId { get; set; }
        public string Type { get; set; }

        public string Texture { get; set; }

    }
}



