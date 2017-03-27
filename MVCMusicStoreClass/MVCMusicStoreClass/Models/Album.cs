using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Web;

namespace MVCMusicStoreClass.Models
{
    public class Album
    {


        public Genre Genre { get; set; }



        public int AlbumID { get; set; }
        public int GenreID { get; set; }
        public int ArtistID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string AlbumArtUrl { get; set; }

       
        public Artist Artist { get; set; }



    }
}