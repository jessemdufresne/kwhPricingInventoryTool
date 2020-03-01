﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace kwh.Migrations
{
    [DbContext(typeof(kwhDataContext))]
    partial class kwhDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("kwh.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("varchar(25) CHARACTER SET utf8mb4")
                        .HasMaxLength(25);

                    b.HasKey("CategoryId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("kwh.Models.Component", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ComponentId")
                        .HasColumnType("int");

                    b.Property<int>("MaturityId")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasColumnType("varchar(40) CHARACTER SET utf8mb4")
                        .HasMaxLength(40);

                    b.Property<string>("PartName")
                        .IsRequired()
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<string>("PartNumber")
                        .HasColumnType("varchar(25) CHARACTER SET utf8mb4")
                        .HasMaxLength(25);

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int>("QuantityCurrent")
                        .HasColumnType("int");

                    b.Property<int>("QuantityNeeded")
                        .HasColumnType("int");

                    b.Property<DateTime>("Timestamp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("UnitCost")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Url")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("VendorId")
                        .HasColumnType("int");

                    b.Property<int>("VolunteerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("MaturityId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("VendorId");

                    b.HasIndex("VolunteerId");

                    b.ToTable("Component");
                });

            modelBuilder.Entity("kwh.Models.Maturity", b =>
                {
                    b.Property<int>("MaturityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("MaturityStatus")
                        .IsRequired()
                        .HasColumnType("varchar(25) CHARACTER SET utf8mb4")
                        .HasMaxLength(25);

                    b.HasKey("MaturityId");

                    b.ToTable("Maturity");
                });

            modelBuilder.Entity("kwh.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ProjectCountry")
                        .IsRequired()
                        .HasColumnType("varchar(25) CHARACTER SET utf8mb4")
                        .HasMaxLength(25);

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("varchar(25) CHARACTER SET utf8mb4")
                        .HasMaxLength(25);

                    b.Property<int>("ProjectYear")
                        .HasColumnType("int");

                    b.HasKey("ProjectId");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("kwh.Models.Vendor", b =>
                {
                    b.Property<int>("VendorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("VendorEmail")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("VendorName")
                        .IsRequired()
                        .HasColumnType("varchar(25) CHARACTER SET utf8mb4")
                        .HasMaxLength(25);

                    b.Property<string>("VendorPhone")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("VendorUrl")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("VendorId");

                    b.ToTable("Vendor");
                });

            modelBuilder.Entity("kwh.Models.Volunteer", b =>
                {
                    b.Property<int>("VolunteerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(25) CHARACTER SET utf8mb4")
                        .HasMaxLength(25);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(25) CHARACTER SET utf8mb4")
                        .HasMaxLength(25);

                    b.Property<string>("VolunteerEmail")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("VolunteerPhone")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("VolunteerId");

                    b.ToTable("Volunteer");
                });

            modelBuilder.Entity("kwh.Models.Component", b =>
                {
                    b.HasOne("kwh.Models.Category", "Category")
                        .WithMany("Components")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kwh.Models.Maturity", "Maturity")
                        .WithMany("Components")
                        .HasForeignKey("MaturityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kwh.Models.Project", "Project")
                        .WithMany("Components")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kwh.Models.Vendor", "Vendor")
                        .WithMany("Components")
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kwh.Models.Volunteer", "Volunteer")
                        .WithMany("Components")
                        .HasForeignKey("VolunteerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
