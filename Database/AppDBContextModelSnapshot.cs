﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backend.Database;

namespace backend.Database
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("PlanetPals___backend.DTOs.CompanyDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BusinessAchievements")
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<int>("Score")
                        .HasMaxLength(250)
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BusinessAchievements = "000000",
                            Email = "support@cercopitechs.com",
                            Name = "Cercopitechs",
                            Password = "parola123",
                            Score = 0
                        });
                });

            modelBuilder.Entity("PlanetPals___backend.DTOs.UserDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Achievements")
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyId")
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("Score")
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Achievements = "000000",
                            CompanyId = "123",
                            Email = "andrei@cercopitechs.com",
                            Name = "Andrei",
                            Password = "parola123"
                        });
                });

            modelBuilder.Entity("backend.DTOs.HistoryDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<string>("PhotoPath")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("actionId")
                        .HasMaxLength(250)
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Actions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PhotoPath = "dummyPath",
                            UserId = 1,
                            actionId = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
