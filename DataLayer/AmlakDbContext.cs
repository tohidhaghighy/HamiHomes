using DomainLayer;
using DomainLayer.Home;
using DomainLayer.Location;
using DomainLayer.Magzine;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class AmlakDbContext:DbContext
    {
        public AmlakDbContext()
        {

        }
        

        public AmlakDbContext(DbContextOptions<AmlakDbContext> options)
    : base(options)
        {

        }
        public DbSet<MetrazSetting> MetrazSetting { get; set; }
        public DbSet<CostSetting> CostSetting { get; set; }
        public DbSet<VadieSetting> VadieSetting { get; set; }
        public DbSet<EjareSetting> EjareSetting { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Mahalle> Mahalles { get; set; }
        public DbSet<Nahie> Nahies { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<HomeGroup> HomeGroups { get; set; }
        public DbSet<HomeFacility> HomeFacilities { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Adviser> Advisers { get; set; }
        public DbSet<Magazine> Magazines { get; set; }
        public DbSet<MagazinGroup> MagazinGroupes { get; set; }

        public DbSet<Home> Homes { get; set; }
        public DbSet<HomeGallery> HomeGalleries { get; set; }

        #region home

        public DbSet<Anbar> Anbars { get; set; }

        public DbSet<Aparteman> Apartemans { get; set; }
        public DbSet<Edari> Edaries { get; set; }
        public DbSet<Garden> Gardenes { get; set; }
        public DbSet<GardenWithVila> gardenWithVilas { get; set; }
        public DbSet<HomewithGarden> HomewithGardens { get; set; }
        public DbSet<Kolangi> Kolangis { get; set; }
        public DbSet<Maghaze> Maghazes { get; set; }
        public DbSet<Moshtghelat> Moshtghelats { get; set; }
        public DbSet<Vila> Vilas { get; set; }
        public DbSet<Zamin> Zamins { get; set; }

        #endregion

        #region setting
        public DbSet<AmlakDivar> AmlakDivar { get; set; }
        public DbSet<AmlakEmtiaz> AmlakEmtiaz { get; set; }
        public DbSet<AmlakEskeleton> AmlakEskeleton { get; set; }
        public DbSet<AmlakJahatVahed> AmlakJahatVahed { get; set; }
        public DbSet<AmlakKaf> AmlakKaf { get; set; }
        public DbSet<AmlakKitchen> AmlakKitchen { get; set; }
        public DbSet<AmlakMelkStatus> AmlakMelkStatus { get; set; }
        public DbSet<AmlakMogheiatMelk> AmlakMogheiatMelk { get; set; }
        public DbSet<AmlakMoshaat> AmlakMoshaat { get; set; }
        public DbSet<AmlakMoshakhase> AmlakMoshakhase { get; set; }
        public DbSet<AmlakNema> AmlakNema { get; set; }
        public DbSet<AmlakNoeZamin> AmlakNoeZamin { get; set; }
        public DbSet<AmlakParking> AmlakParking { get; set; }

        public DbSet<AmlakPishraftStatus> AmlakPishraftStatus { get; set; }
        public DbSet<AmlakSaghf> AmlakSaghf { get; set; }
        public DbSet<AmlakSanadStatus> AmlakSanadStatus { get; set; }
        public DbSet<AmlakTasisatGarmaieshi> AmlakTasisatGarmaieshi { get; set; }
        public DbSet<AmlakWC> AmlakWC { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>().ToTable("Admin");
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Log>().ToTable("Log");
            modelBuilder.Entity<Nahie>().ToTable("Nahie");
            modelBuilder.Entity<Mahalle>().ToTable("Mahale");
            modelBuilder.Entity<City>().ToTable("City");
            modelBuilder.Entity<Region>().ToTable("Region");
            modelBuilder.Entity<HomeGroup>().ToTable("HomeGroup");
            modelBuilder.Entity<HomeFacility>().ToTable("HomeFacility");
            modelBuilder.Entity<Setting>().ToTable("Setting");
            modelBuilder.Entity<Adviser>().ToTable("Adviser");
            modelBuilder.Entity<Magazine>().ToTable("Magazin");
            modelBuilder.Entity<MagazinGroup>().ToTable("MagazinGroup");
            modelBuilder.Entity<Home>().ToTable("Home");
            modelBuilder.Entity<HomeGallery>().ToTable("HomeGallery");
        }
    }
}
