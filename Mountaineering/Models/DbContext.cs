using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mountaineering.Models
{
    public class DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Purchases { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Lifehaki> Lifehakis { get; set; }

    }
}