using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.Database.Entities;

namespace Weather.Database
{
    internal class WeatherDBContext: DbContext
    {
        internal DbSet<LocationEntity> Locations { get; set; }
        internal DbSet<object> Weather { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            ConfigureLocation(modelBuilder);
            ConfigureWeather(modelBuilder);
        }

        private void ConfigureLocation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LocationEntity>()
               .HasKey(x => x.Id);
            modelBuilder.Entity<LocationEntity>()
                .Property(x => x.LocationName)
                .IsRequired();
        }

        private void ConfigureWeather(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WeatherEntity>()
               .HasKey(x => x.Id);
            modelBuilder.Entity<WeatherEntity>()
                .Property(x => x.Description)
                .IsRequired();

            modelBuilder.Entity<WeatherEntity>()
                .HasOne(x => x.Location)
                .WithOne()
                .HasForeignKey<WeatherEntity>(x => x.LocationId);
        }
    }
}
