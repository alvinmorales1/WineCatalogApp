﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WineCatalogApp;

namespace WineCatalogApp.Migrations
{
    [DbContext(typeof(Winecontext))]
    [Migration("20200302021654_initial2")]
    partial class initial2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WineCatalogApp.WineInformation", b =>
                {
                    b.Property<int>("WineIDNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommentsEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RecordedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<string>("SampledDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Vintange")
                        .HasColumnType("int");

                    b.Property<string>("WineComments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WineName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("WineNotes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("WinePrice")
                        .HasColumnType("float")
                        .HasMaxLength(10);

                    b.Property<string>("WineRegion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WineScore")
                        .HasColumnType("int");

                    b.Property<string>("WineVarietals")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WineryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("WineIDNumber")
                        .HasName("PK_Wines");

                    b.ToTable("Wines");
                });
#pragma warning restore 612, 618
        }
    }
}
