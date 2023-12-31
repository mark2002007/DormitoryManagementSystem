﻿// <auto-generated />
using System;
using DormitoryManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DormitoryManagementSystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("DormitoryManagementSystem.Models.Dean", b =>
                {
                    b.Property<int>("DeanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("FacultyId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UserID")
                        .HasColumnType("INTEGER");

                    b.HasKey("DeanID");

                    b.ToTable("Deans");
                });

            modelBuilder.Entity("DormitoryManagementSystem.Models.Dormitory", b =>
                {
                    b.Property<int>("DormitoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DormitoryNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("DormitoryID");

                    b.ToTable("Dormitories");
                });

            modelBuilder.Entity("DormitoryManagementSystem.Models.Faculty", b =>
                {
                    b.Property<int>("FacultyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DeanId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FacultyName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("FacultyID");

                    b.HasIndex("DeanId")
                        .IsUnique();

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("DormitoryManagementSystem.Models.Rector", b =>
                {
                    b.Property<int>("RectorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UserID")
                        .HasColumnType("INTEGER");

                    b.HasKey("RectorID");

                    b.ToTable("Rectors");
                });

            modelBuilder.Entity("DormitoryManagementSystem.Models.Resident", b =>
                {
                    b.Property<int>("ResidentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AssignedFacultyFacultyID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AssignedRoomRoomID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UserID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ResidentID");

                    b.HasIndex("AssignedFacultyFacultyID");

                    b.HasIndex("AssignedRoomRoomID");

                    b.ToTable("Residents");
                });

            modelBuilder.Entity("DormitoryManagementSystem.Models.Room", b =>
                {
                    b.Property<int>("RoomID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AssignedDormitoryDormitoryID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AssignedFacultyFacultyID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Capacity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("RoomNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("RoomID");

                    b.HasIndex("AssignedDormitoryDormitoryID");

                    b.HasIndex("AssignedFacultyFacultyID");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("DormitoryManagementSystem.Models.Warden", b =>
                {
                    b.Property<int>("WardenID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AssignedDormitoryFacultyID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UserID")
                        .HasColumnType("INTEGER");

                    b.HasKey("WardenID");

                    b.HasIndex("AssignedDormitoryFacultyID");

                    b.ToTable("Wardens");
                });

            modelBuilder.Entity("DormitoryManagementSystem.Models.Faculty", b =>
                {
                    b.HasOne("DormitoryManagementSystem.Models.Dean", "Dean")
                        .WithOne("Faculty")
                        .HasForeignKey("DormitoryManagementSystem.Models.Faculty", "DeanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dean");
                });

            modelBuilder.Entity("DormitoryManagementSystem.Models.Resident", b =>
                {
                    b.HasOne("DormitoryManagementSystem.Models.Faculty", "AssignedFaculty")
                        .WithMany()
                        .HasForeignKey("AssignedFacultyFacultyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DormitoryManagementSystem.Models.Room", "AssignedRoom")
                        .WithMany("Residents")
                        .HasForeignKey("AssignedRoomRoomID");

                    b.Navigation("AssignedFaculty");

                    b.Navigation("AssignedRoom");
                });

            modelBuilder.Entity("DormitoryManagementSystem.Models.Room", b =>
                {
                    b.HasOne("DormitoryManagementSystem.Models.Dormitory", "AssignedDormitory")
                        .WithMany("Rooms")
                        .HasForeignKey("AssignedDormitoryDormitoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DormitoryManagementSystem.Models.Faculty", "AssignedFaculty")
                        .WithMany("AssignedRooms")
                        .HasForeignKey("AssignedFacultyFacultyID");

                    b.Navigation("AssignedDormitory");

                    b.Navigation("AssignedFaculty");
                });

            modelBuilder.Entity("DormitoryManagementSystem.Models.Warden", b =>
                {
                    b.HasOne("DormitoryManagementSystem.Models.Faculty", "AssignedDormitory")
                        .WithMany()
                        .HasForeignKey("AssignedDormitoryFacultyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AssignedDormitory");
                });

            modelBuilder.Entity("DormitoryManagementSystem.Models.Dean", b =>
                {
                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("DormitoryManagementSystem.Models.Dormitory", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("DormitoryManagementSystem.Models.Faculty", b =>
                {
                    b.Navigation("AssignedRooms");
                });

            modelBuilder.Entity("DormitoryManagementSystem.Models.Room", b =>
                {
                    b.Navigation("Residents");
                });
#pragma warning restore 612, 618
        }
    }
}
