﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace myproject.Migrations
{
    [DbContext(typeof(MyProjectDbContext))]
    [Migration("20230412210208_SeedingDataHotelCountries")]
    partial class SeedingDataHotelCountries
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Pakistan",
                            ShortName = "pk"
                        },
                        new
                        {
                            Id = 2,
                            Name = "India",
                            ShortName = "In"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Afganistan",
                            ShortName = "Afg"
                        });
                });

            modelBuilder.Entity("Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Punjab,Pakistan",
                            CountryId = 1,
                            Name = "RuralArea",
                            Rating = 4.2000000000000002
                        },
                        new
                        {
                            Id = 2,
                            Address = "Punjab,India",
                            CountryId = 2,
                            Name = "AlinaHotel",
                            Rating = 4.5
                        },
                        new
                        {
                            Id = 3,
                            Address = "Kabul,Afghanistan",
                            CountryId = 3,
                            Name = "Rachna",
                            Rating = 4.5999999999999996
                        });
                });

            modelBuilder.Entity("Hotel", b =>
                {
                    b.HasOne("Country", "Country")
                        .WithMany("Hotels")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Country", b =>
                {
                    b.Navigation("Hotels");
                });
#pragma warning restore 612, 618
        }
    }
}