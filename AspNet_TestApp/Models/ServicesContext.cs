using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet_TestApp.Models
{
    public class ServicesContext: DbContext
    {
        public DbSet<Services> Services { get; set; }
        public DbSet<Order> Orders { get; set; }

        public ServicesContext(DbContextOptions<ServicesContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasIndex(p => new { p.Data })
                .IsUnique(true);
        }
    }
}
