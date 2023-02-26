﻿// <auto-generated />
using DataloggerDesktops.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataloggerDesktops.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("DataloggerDesktops.Models.DBiComox", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("dateTime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("registerAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("registerDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("registerValue")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("DBiComoxes");
                });
#pragma warning restore 612, 618
        }
    }
}
