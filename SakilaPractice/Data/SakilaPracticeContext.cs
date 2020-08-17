using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SakilaPractice.Models;

namespace SakilaPractice.Data
{
    public class SakilaPracticeContext : DbContext
    {
        public SakilaPracticeContext (DbContextOptions<SakilaPracticeContext> options)
            : base(options)
        {
        }

        public DbSet<SakilaPractice.Models.film_actor> film_actor { get; set; }

        public DbSet<SakilaPractice.Models.film_category> film_category { get; set; }

        public DbSet<SakilaPractice.Models.Inventory> Inventory { get; set; }
    }
}
