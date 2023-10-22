﻿// <auto-generated />
using EFCoreSQLiteDemo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DormitoryManagementSystem.Migrations
{
    [DbContext(typeof(DormitoryContext))]
    [Migration("20231022051023_20231022080900_InitialCreate")]
    partial class _20231022080900_InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.12");

            modelBuilder.Entity("EFCoreSQLiteDemo.Faculty", b =>
                {
                    b.Property<int>("FacultyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FacultyName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("FacultyID");

                    b.ToTable("Faculty");
                });

            modelBuilder.Entity("EFCoreSQLiteDemo.Resident", b =>
                {
                    b.Property<int>("ResidentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AssignedFacultyFacultyID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AssignedRoomRoomID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ResidentID");

                    b.HasIndex("AssignedFacultyFacultyID");

                    b.HasIndex("AssignedRoomRoomID");

                    b.ToTable("Residents");
                });

            modelBuilder.Entity("EFCoreSQLiteDemo.Room", b =>
                {
                    b.Property<int>("RoomID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AssignedFacultyFacultyID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Capacity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("RoomID");

                    b.HasIndex("AssignedFacultyFacultyID");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("EFCoreSQLiteDemo.Resident", b =>
                {
                    b.HasOne("EFCoreSQLiteDemo.Faculty", "AssignedFaculty")
                        .WithMany()
                        .HasForeignKey("AssignedFacultyFacultyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreSQLiteDemo.Room", "AssignedRoom")
                        .WithMany("Residents")
                        .HasForeignKey("AssignedRoomRoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AssignedFaculty");

                    b.Navigation("AssignedRoom");
                });

            modelBuilder.Entity("EFCoreSQLiteDemo.Room", b =>
                {
                    b.HasOne("EFCoreSQLiteDemo.Faculty", "AssignedFaculty")
                        .WithMany("AssignedRooms")
                        .HasForeignKey("AssignedFacultyFacultyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AssignedFaculty");
                });

            modelBuilder.Entity("EFCoreSQLiteDemo.Faculty", b =>
                {
                    b.Navigation("AssignedRooms");
                });

            modelBuilder.Entity("EFCoreSQLiteDemo.Room", b =>
                {
                    b.Navigation("Residents");
                });
#pragma warning restore 612, 618
        }
    }
}
