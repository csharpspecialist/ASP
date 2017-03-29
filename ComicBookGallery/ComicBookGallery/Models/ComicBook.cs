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


        public string DisplayText

        {
            get
            {    // this is a read only property since it does not have a setter

                return SeriesTitle + "#  " + IssueNumber;
            }                   

        }
        //series -  title - issueNumber.jpg
        public string CoverImageFileName
        {
            get 
            {// this is a read only property since it does not have a setter
               return SeriesTitle.Replace(" ", "-")
                    .ToLower() + "-" + IssueNumber + ".jpg";
            }

        }                

    }
}