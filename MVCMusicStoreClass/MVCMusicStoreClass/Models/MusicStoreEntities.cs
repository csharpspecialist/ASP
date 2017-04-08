using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCMusicStoreClass.Models
{
    public class MusicStoreEntities : DbContext 
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }



    }
}