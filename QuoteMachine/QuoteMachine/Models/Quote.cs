using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Web;

namespace QuoteMachine.Models
{
    public class Quote
    {
        private static Random randomizer = new Random();


        private static List<Quote> FamousQuotes =
            new List<Quote>
     {
                new Quote{Author="Andy Warhol" ,
                Contents="In the future everyone " +
                "will be world-famous for fifteen minutes." },
                 new Quote{Author="Louis Hector Berlioz" ,
                 Contents="Time is a great teacher, " +
                 "but unfortunately it kills all its pupils." }
                 };

                public string Contents { get; set; }
                 public string Author { get; set; }
    
                 public static Quote ChooseRandomQuote()
                 {
                 int randomIndex = randomizer.Next(FamousQuotes.Count);
                 return FamousQuotes[randomIndex];
                 }



        }
}