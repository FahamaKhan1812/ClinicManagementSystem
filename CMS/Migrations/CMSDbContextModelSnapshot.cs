﻿// <auto-generated />
using System;
using CMS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CMS.Migrations
{
    [DbContext(typeof(CMSDbContext))]
    partial class CMSDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CMS.Models.Appointment", b =>
                {
                    b.Property<int>("AppointID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AppointID"), 1L, 1);

                    b.Property<int>("Appointment_Status")
                        .HasColumnType("int");

                    b.Property<float>("BillAmount")
                        .HasColumnType("real");

                    b.Property<string>("BillStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Disease")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoctorID")
                        .HasColumnType("int");

                    b.Property<int>("DoctorNotification")
                        .HasColumnType("int");

                    b.Property<int>("FeedbackStatus")
                        .HasColumnType("int");

                    b.Property<int>("PatientID")
                        .HasColumnType("int");

                    b.Property<int>("PatientNotification")
                        .HasColumnType("int");

                    b.Property<string>("Prescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Progress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AppointID");

                    b.ToTable("Appointment");
                });

            modelBuilder.Entity("CMS.Models.Doctor", b =>
                {
                    b.Property<int>("DoctorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DoctorID"), 1L, 1);

                    b.Property<int>("Charges")
                        .HasColumnType("int");

                    b.Property<string>("DoctorAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoctorAge")
                        .HasColumnType("int");

                    b.Property<string>("DoctorGender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorPhone")
                        .HasColumnType("char(10)");

                    b.Property<string>("Qualification")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Specialization")
                        .HasColumnType("varchar(50)");

                    b.HasKey("DoctorID");

                    b.ToTable("Doctor");
                });

            modelBuilder.Entity("CMS.Models.Patient", b =>
                {
                    b.Property<int>("PatientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PatientID"), 1L, 1);

                    b.Property<string>("PatientAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientAge")
                        .HasColumnType("int");

                    b.Property<string>("PatientGender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatientName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientPhone")
                        .HasColumnType("int");

                    b.HasKey("PatientID");

                    b.ToTable("Patient");
                });
#pragma warning restore 612, 618
        }
    }
}
