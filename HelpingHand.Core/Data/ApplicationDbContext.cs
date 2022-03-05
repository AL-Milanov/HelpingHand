using HelpingHand.Core.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HelpingHand.Core.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<City> Cities { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Clothes> Clothes { get; set; }

        public DbSet<Food> Foods { get; set; }

        public DbSet<Shelter> Shelters { get; set; }

        public DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<City>()
                .HasIndex(c => c.Name)
                .IsUnique();

            builder.Entity<Country>()
                .HasIndex(c => c.Name)
                .IsUnique();

            base.OnModelCreating(builder);
        }
    }
}