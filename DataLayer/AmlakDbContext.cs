using DomainLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class AmlakDbContext:DbContext
    {
        public AmlakDbContext(DbContextOptions<AmlakDbContext> options) : base(options)
        {

        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<HomeGroup> HomeGroups { get; set; }
        public DbSet<HomeFacility> HomeFacilities { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Adviser> Advisers { get; set; }
        public DbSet<Magzine> Magzine { get; set; }
        public DbSet<MagzineType> MagzineType { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>().ToTable("Admin");
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Log>().ToTable("Log");
            modelBuilder.Entity<City>().ToTable("City");
            modelBuilder.Entity<Region>().ToTable("Region");
            modelBuilder.Entity<HomeGroup>().ToTable("HomeGroup");
            modelBuilder.Entity<HomeFacility>().ToTable("HomeFacility");
            modelBuilder.Entity<Setting>().ToTable("Setting");
            modelBuilder.Entity<Adviser>().ToTable("Adviser");
            modelBuilder.Entity<Magzine>().ToTable("Magzine");
            modelBuilder.Entity<MagzineType>().ToTable("MagzineType");
        }
    }
}
