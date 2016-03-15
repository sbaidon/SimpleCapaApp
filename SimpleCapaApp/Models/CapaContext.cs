using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SimpleCapaApp.Models
{
    public class CapaContext : DbContext
    {
        public DbSet<Administrator> People { get; set; }

        public System.Data.Entity.DbSet<Task> Tasks { get; set; }

        public DbSet<User> Users { get; set; }
    }
}

