using Loundry.Settings;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using Loundry.Models;

namespace Loundry.Models
{
    class ApplicationContext : DbContext
    {
        public DbSet<Booking> bookings { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Laundry> laundries { get; set; }

        public ApplicationContext()
        {
            //Database.OpenConnection();
            Database.EnsureCreated();
            
            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            NpgsqlConnection.GlobalTypeMapper.MapEnum<Laundry.day_of_week>();
            optionsBuilder.UseNpgsql("Host=balarama.db.elephantsql.com ; Port=5432;Database=blcleyyu ;Username=blcleyyu ;Password=WoFMB8E4iOExGedI8KOjZA5D9YY7_EON ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresEnum<Laundry.day_of_week>();
            modelBuilder.Entity<Customer>()
                .Property(b => b.Id)
                .HasDefaultValue(0);
            modelBuilder.Entity<Booking>()
                .Property(b => b.Id)
                .HasDefaultValue(0);
            modelBuilder.Entity<Laundry>()
                .Property(b => b.Id)
                .HasDefaultValue(0);

        }
    }
}
