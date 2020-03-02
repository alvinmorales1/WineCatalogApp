using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace WineCatalogApp
{
    class Winecontext : DbContext
    {
        public DbSet<WineInformation> Wines { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=WineDb;Integrated Security=True;Connect Timeout=30;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WineInformation>(e =>
            {
                e.ToTable("Wines");
                e.HasKey(a => a.WineIDNumber)
                    .HasName("PK_Wines");
                e.Property(a => a.WineIDNumber)
                    .ValueGeneratedOnAdd();
                e.Property(a => a.WineName)
                    .HasMaxLength(100)
                    .IsRequired();
                e.Property(a => a.WineNotes)
                    .IsRequired();
                e.Property(a => a.WinePrice)
                    .HasMaxLength(10);
                e.Property(a => a.WineRegion)
                    .IsRequired();
                e.Property(a => a.WineryName)
                    .HasMaxLength(100)
                    .IsRequired();
                e.Property(a => a.SampledDate)
                    .IsRequired();
                Microsoft.EntityFrameworkCore.Metadata.Builders.PropertyBuilder<DateTime> propertyBuilder = e.Property(a => a.RecordedDate)
                    .ValueGeneratedOnAdd()
                    .IsRequired();
                e.Property(a => a.Vintange)
                     .IsRequired();
                e.Property(a => a.WineVarietals)
                    .IsRequired();
                
            });
        }
    }
}
