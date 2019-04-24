using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PlanetSync_Server.Data.Models;

namespace PlanetSync_Server.Data
{
    public class PsContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Mod> Mods { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=planetsync.db");
        }
    }
}
