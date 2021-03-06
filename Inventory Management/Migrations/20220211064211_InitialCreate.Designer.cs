// <auto-generated />
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
    [Migration("20220211064211_InitialCreate")]
    partial class InitialCreate
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
