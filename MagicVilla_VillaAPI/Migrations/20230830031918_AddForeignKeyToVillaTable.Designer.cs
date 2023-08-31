﻿// <auto-generated />
using System;
using MagicVilla_VillaAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230830031918_AddForeignKeyToVillaTable")]
    partial class AddForeignKeyToVillaTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 8, 29, 20, 19, 18, 229, DateTimeKind.Local).AddTicks(651),
                            Details = "Dummy text here and here and here and here",
                            ImageUrl = "",
                            Name = "Royal Villa",
                            Occupancy = 5,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 8, 29, 20, 19, 18, 229, DateTimeKind.Local).AddTicks(764),
                            Details = "Dummy text here and here and here and here",
                            ImageUrl = "",
                            Name = "Royal Villa 2",
                            Occupancy = 5,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 8, 29, 20, 19, 18, 229, DateTimeKind.Local).AddTicks(1221),
                            Details = "Dummy text here and here and here and here",
                            ImageUrl = "",
                            Name = "Royal Villa 3",
                            Occupancy = 5,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 8, 29, 20, 19, 18, 229, DateTimeKind.Local).AddTicks(1247),
                            Details = "Dummy text here and here and here and here",
                            ImageUrl = "",
                            Name = "Royal Villa 4",
                            Occupancy = 5,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 8, 29, 20, 19, 18, 229, DateTimeKind.Local).AddTicks(1258),
                            Details = "Dummy text here and here and here and here",
                            ImageUrl = "",
                            Name = "Royal Villa 5",
                            Occupancy = 5,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.VillaNumber", b =>
                {
                    b.Property<int>("VillaNum")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SpecialDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("VillaID")
                        .HasColumnType("int");

                    b.HasKey("VillaNum");

                    b.HasIndex("VillaID");

                    b.ToTable("VillaNumbers");

                    b.HasData(
                        new
                        {
                            VillaNum = 1,
                            CreatedDate = new DateTime(2023, 8, 29, 20, 19, 18, 229, DateTimeKind.Local).AddTicks(1990),
                            SpecialDetails = "None 1",
                            UpdatedDate = new DateTime(2023, 8, 29, 20, 19, 18, 229, DateTimeKind.Local).AddTicks(2011),
                            VillaID = 0
                        },
                        new
                        {
                            VillaNum = 2,
                            CreatedDate = new DateTime(2023, 8, 29, 20, 19, 18, 229, DateTimeKind.Local).AddTicks(2021),
                            SpecialDetails = "None 2",
                            UpdatedDate = new DateTime(2023, 8, 29, 20, 19, 18, 229, DateTimeKind.Local).AddTicks(2027),
                            VillaID = 0
                        },
                        new
                        {
                            VillaNum = 3,
                            CreatedDate = new DateTime(2023, 8, 29, 20, 19, 18, 229, DateTimeKind.Local).AddTicks(2036),
                            SpecialDetails = "None 3",
                            UpdatedDate = new DateTime(2023, 8, 29, 20, 19, 18, 229, DateTimeKind.Local).AddTicks(2043),
                            VillaID = 0
                        },
                        new
                        {
                            VillaNum = 4,
                            CreatedDate = new DateTime(2023, 8, 29, 20, 19, 18, 229, DateTimeKind.Local).AddTicks(2051),
                            SpecialDetails = "None 4",
                            UpdatedDate = new DateTime(2023, 8, 29, 20, 19, 18, 229, DateTimeKind.Local).AddTicks(2057),
                            VillaID = 0
                        },
                        new
                        {
                            VillaNum = 5,
                            CreatedDate = new DateTime(2023, 8, 29, 20, 19, 18, 229, DateTimeKind.Local).AddTicks(2066),
                            SpecialDetails = "None 5",
                            UpdatedDate = new DateTime(2023, 8, 29, 20, 19, 18, 229, DateTimeKind.Local).AddTicks(2072),
                            VillaID = 0
                        });
                });

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.VillaNumber", b =>
                {
                    b.HasOne("MagicVilla_VillaAPI.Models.Villa", "Villa")
                        .WithMany()
                        .HasForeignKey("VillaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Villa");
                });
#pragma warning restore 612, 618
        }
    }
}
