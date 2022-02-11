﻿// <auto-generated />
using System;
using Inventory_Management.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Inventory_Management.Migrations
{
    [DbContext(typeof(InventoryManagementContext))]
    [Migration("20220211163815_seedings")]
    partial class seedings
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.2");

            modelBuilder.Entity("Inventory_Management.Models.Asset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AssetNumber")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("AssignedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DiscardedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastReturnedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("PurchasedDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TypeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AssetNumber")
                        .IsUnique();

                    b.HasIndex("TypeId");

                    b.ToTable("Assets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AssetNumber = "C8619B9",
                            PurchasedDate = new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 0,
                            TypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            AssetNumber = "C8619BA",
                            PurchasedDate = new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 0,
                            TypeId = 2
                        },
                        new
                        {
                            Id = 3,
                            AssetNumber = "C8619BB",
                            PurchasedDate = new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 0,
                            TypeId = 3
                        },
                        new
                        {
                            Id = 4,
                            AssetNumber = "C8619BC",
                            PurchasedDate = new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 0,
                            TypeId = 4
                        },
                        new
                        {
                            Id = 5,
                            AssetNumber = "C8619BD",
                            PurchasedDate = new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 0,
                            TypeId = 5
                        },
                        new
                        {
                            Id = 6,
                            AssetNumber = "C8619C2",
                            LastReturnedDate = new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            PurchasedDate = new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            TypeId = 1
                        },
                        new
                        {
                            Id = 7,
                            AssetNumber = "C8619C3",
                            LastReturnedDate = new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            PurchasedDate = new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            TypeId = 2
                        },
                        new
                        {
                            Id = 8,
                            AssetNumber = "C8619C4",
                            LastReturnedDate = new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            PurchasedDate = new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            TypeId = 3
                        },
                        new
                        {
                            Id = 9,
                            AssetNumber = "C8619C5",
                            LastReturnedDate = new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            PurchasedDate = new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            TypeId = 4
                        },
                        new
                        {
                            Id = 10,
                            AssetNumber = "C861A26",
                            DiscardedDate = new DateTime(2021, 1, 20, 14, 15, 0, 0, DateTimeKind.Unspecified),
                            PurchasedDate = new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 2,
                            TypeId = 1
                        },
                        new
                        {
                            Id = 11,
                            AssetNumber = "C861A27",
                            DiscardedDate = new DateTime(2021, 1, 20, 14, 15, 0, 0, DateTimeKind.Unspecified),
                            PurchasedDate = new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 2,
                            TypeId = 2
                        });
                });

            modelBuilder.Entity("Inventory_Management.Models.AssetType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("AssetTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Monitor"
                        },
                        new
                        {
                            Id = 2,
                            Name = "CPU"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Keyboard"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Mouse"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Printer"
                        });
                });

            modelBuilder.Entity("Inventory_Management.Models.AssignmentHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AssetId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AssignedDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("StaffId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("UnAssignedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.HasIndex("StaffId");

                    b.ToTable("AssetsHistory");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AssetId = 6,
                            AssignedDate = new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            StaffId = 2
                        },
                        new
                        {
                            Id = 2,
                            AssetId = 7,
                            AssignedDate = new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            StaffId = 2
                        },
                        new
                        {
                            Id = 3,
                            AssetId = 8,
                            AssignedDate = new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            StaffId = 2
                        },
                        new
                        {
                            Id = 4,
                            AssetId = 9,
                            AssignedDate = new DateTime(2021, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            StaffId = 2
                        });
                });

            modelBuilder.Entity("Inventory_Management.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Administration"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Accounts"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Human Resources"
                        });
                });

            modelBuilder.Entity("Inventory_Management.Models.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("TEXT");

                    b.Property<string>("NationalIdentificationNumber")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("TEXT")
                        .HasColumnName("NID");

                    b.Property<string>("StaffNumber")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("NationalIdentificationNumber")
                        .IsUnique();

                    b.HasIndex("StaffNumber")
                        .IsUnique();

                    b.ToTable("Staffs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartmentId = 1,
                            Name = "Ahmed Mohamed",
                            NationalIdentificationNumber = "A123456",
                            StaffNumber = "A001"
                        },
                        new
                        {
                            Id = 2,
                            DepartmentId = 1,
                            Name = "Hussain Ali",
                            NationalIdentificationNumber = "A223422",
                            StaffNumber = "A002"
                        },
                        new
                        {
                            Id = 3,
                            DepartmentId = 2,
                            Name = "Fathimath Moosa Manik",
                            NationalIdentificationNumber = "A323433",
                            StaffNumber = "B003"
                        },
                        new
                        {
                            Id = 4,
                            DepartmentId = 2,
                            Name = "Ibrahim Hussain",
                            NationalIdentificationNumber = "A423444",
                            StaffNumber = "A017"
                        },
                        new
                        {
                            Id = 5,
                            DepartmentId = 3,
                            Name = "Aishath Mariyam",
                            NationalIdentificationNumber = "A523455",
                            StaffNumber = "EE01"
                        },
                        new
                        {
                            Id = 6,
                            DepartmentId = 3,
                            Name = "Hassan Ali Ibrahim",
                            NationalIdentificationNumber = "A623466",
                            StaffNumber = "AE001"
                        });
                });

            modelBuilder.Entity("Inventory_Management.Models.Asset", b =>
                {
                    b.HasOne("Inventory_Management.Models.AssetType", "AssetType")
                        .WithMany("Assets")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AssetType");
                });

            modelBuilder.Entity("Inventory_Management.Models.AssignmentHistory", b =>
                {
                    b.HasOne("Inventory_Management.Models.Asset", "Asset")
                        .WithMany("AssignmentHistory")
                        .HasForeignKey("AssetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inventory_Management.Models.Staff", "Staff")
                        .WithMany("AssignmentHistory")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asset");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("Inventory_Management.Models.Staff", b =>
                {
                    b.HasOne("Inventory_Management.Models.Department", "Department")
                        .WithMany("Staffs")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Inventory_Management.Models.Asset", b =>
                {
                    b.Navigation("AssignmentHistory");
                });

            modelBuilder.Entity("Inventory_Management.Models.AssetType", b =>
                {
                    b.Navigation("Assets");
                });

            modelBuilder.Entity("Inventory_Management.Models.Department", b =>
                {
                    b.Navigation("Staffs");
                });

            modelBuilder.Entity("Inventory_Management.Models.Staff", b =>
                {
                    b.Navigation("AssignmentHistory");
                });
#pragma warning restore 612, 618
        }
    }
}