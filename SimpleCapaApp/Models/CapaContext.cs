using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SimpleCapaApp.Models
{
    public class CapaContext : DbContext
    {

        public DbSet<Administrator> Administrators { get; set; }

        public DbSet<Task> Tasks { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<File> Files { get; set; }

        public DbSet<Capa> Capas { get; set; }
    }
}

