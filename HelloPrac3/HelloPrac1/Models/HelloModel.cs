using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Web;

namespace HelloPrac1.Models
{
    public class HelloModel
    {
       public static List<Drive> GetCarInfo()
        {
            List<Drive> auto = new List<Drive> {
            new Drive { Id = 1, Make = "Mercury", Model = "MKZ" },
            new Drive { Id = 2, Make = "Ford", Model = "Explorer" },
            new Drive { Id = 3, Make = "BMW", Model = "330I" }

            };               
                        
            return auto;
        }




    }

    public class Drive
    {
        public int Id { get; set; }
        public string Make { get; set; }

        public string Model { get; set; }
        
    }



}