﻿// <auto-generated />
using System;
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

            modelBuilder.Entity("DataloggerDesktops.Models.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("TEXT");

                    b.Property<string>("DeviceCode")
                        .HasColumnType("TEXT");

                    b.Property<int?>("LineId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<float?>("Value")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("LineId");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("DataloggerDesktops.Models.Factory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Factories");
                });

            modelBuilder.Entity("DataloggerDesktops.Models.Line", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("FactoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("FactoryId");

                    b.ToTable("Lines");
                });

            modelBuilder.Entity("DataloggerDesktops.Models.ParametterLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ParametterSensorId")
                        .HasColumnType("INTEGER");

                    b.Property<float?>("Value")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("ParametterSensorId");

                    b.ToTable("ParametterLogs");
                });

            modelBuilder.Entity("DataloggerDesktops.Models.ParametterSensor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("DeviceId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DeviceId");

                    b.ToTable("ParametterSensors");
                });

            modelBuilder.Entity("DataloggerDesktops.Models.ParametterSetting", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("Action")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Condition")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Item")
                        .HasColumnType("TEXT");

                    b.Property<int?>("SensorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StatusName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Threshold")
                        .HasColumnType("TEXT");

                    b.Property<int?>("UnitId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SensorId");

                    b.ToTable("ParametterSettings");
                });

            modelBuilder.Entity("DataloggerDesktops.Models.Sensor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Sensors");
                });

            modelBuilder.Entity("DataloggerDesktops.Models.UserHistorical", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateLogIn")
                        .HasColumnType("TEXT");

                    b.Property<string>("NameLogIn")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("UserHistoricals");
                });

            modelBuilder.Entity("DataloggerDesktops.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BirthDay")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Fullname")
                        .HasColumnType("TEXT");

                    b.Property<string>("Mobile")
                        .HasColumnType("TEXT");

                    b.Property<string>("NameLogIn")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DataloggerDesktops.Models.Device", b =>
                {
                    b.HasOne("DataloggerDesktops.Models.Line", "Line")
                        .WithMany("Devices")
                        .HasForeignKey("LineId");

                    b.Navigation("Line");
                });

            modelBuilder.Entity("DataloggerDesktops.Models.Line", b =>
                {
                    b.HasOne("DataloggerDesktops.Models.Factory", "Factory")
                        .WithMany("Line")
                        .HasForeignKey("FactoryId");

                    b.Navigation("Factory");
                });

            modelBuilder.Entity("DataloggerDesktops.Models.ParametterLog", b =>
                {
                    b.HasOne("DataloggerDesktops.Models.ParametterSensor", "ParametterSensor")
                        .WithMany("ParametterLogs")
                        .HasForeignKey("ParametterSensorId");

                    b.Navigation("ParametterSensor");
                });

            modelBuilder.Entity("DataloggerDesktops.Models.ParametterSensor", b =>
                {
                    b.HasOne("DataloggerDesktops.Models.Device", null)
                        .WithMany("ParametterSensors")
                        .HasForeignKey("DeviceId");
                });

            modelBuilder.Entity("DataloggerDesktops.Models.ParametterSetting", b =>
                {
                    b.HasOne("DataloggerDesktops.Models.Sensor", "Sensor")
                        .WithMany("ParametterSettings")
                        .HasForeignKey("SensorId");

                    b.Navigation("Sensor");
                });

            modelBuilder.Entity("DataloggerDesktops.Models.Device", b =>
                {
                    b.Navigation("ParametterSensors");
                });

            modelBuilder.Entity("DataloggerDesktops.Models.Factory", b =>
                {
                    b.Navigation("Line");
                });

            modelBuilder.Entity("DataloggerDesktops.Models.Line", b =>
                {
                    b.Navigation("Devices");
                });

            modelBuilder.Entity("DataloggerDesktops.Models.ParametterSensor", b =>
                {
                    b.Navigation("ParametterLogs");
                });

            modelBuilder.Entity("DataloggerDesktops.Models.Sensor", b =>
                {
                    b.Navigation("ParametterSettings");
                });
#pragma warning restore 612, 618
        }
    }
}
