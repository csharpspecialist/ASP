using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class ComicBook
    {
        public int BookID { get; set; }
        public string  SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHTML { get; set; }
        public Artists [] Artists { get; set; }
        public bool Favorite { get; set; }


    }
}