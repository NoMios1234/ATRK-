using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class InitContext : DbContext
    {
        public DbSet<Song> Songs { get; set; } 
        public DbSet<Sound> Sounds { get; set; }
        public DbSet<Settings> Settings { get; set; }

    }
}