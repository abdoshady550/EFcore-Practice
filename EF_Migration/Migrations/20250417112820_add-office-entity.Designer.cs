﻿// <auto-generated />
using EF_Migration.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF_Migration.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250417112820_add-office-entity")]
    partial class Addofficeentity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EF_Migration.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<decimal>("Price")
                        .HasPrecision(15, 2)
                        .HasColumnType("decimal");

                    b.HasKey("Id");

                    b.ToTable("Courses", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseName = "Mathmatics",
                            Price = 1000m
                        },
                        new
                        {
                            Id = 2,
                            CourseName = "Physics",
                            Price = 2000m
                        },
                        new
                        {
                            Id = 3,
                            CourseName = "Chemistry",
                            Price = 1500m
                        },
                        new
                        {
                            Id = 4,
                            CourseName = "Biology",
                            Price = 1200m
                        },
                        new
                        {
                            Id = 5,
                            CourseName = "CS-50",
                            Price = 3000m
                        });
                });

            modelBuilder.Entity("EF_Migration.Entities.Instractor", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("Lname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.Property<int?>("officeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("officeId")
                        .IsUnique()
                        .HasFilter("[officeId] IS NOT NULL");

                    b.ToTable("Instractors", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Fname = "Ahmed",
                            Lname = "Khalid",
                            officeId = 1
                        },
                        new
                        {
                            Id = 2,
                            Fname = "Yasmeen",
                            Lname = "Sobhy",
                            officeId = 2
                        },
                        new
                        {
                            Id = 3,
                            Fname = "Khalid",
                            Lname = "Hossam",
                            officeId = 3
                        },
                        new
                        {
                            Id = 4,
                            Fname = "Nadia",
                            Lname = "Hessen",
                            officeId = 4
                        },
                        new
                        {
                            Id = 5,
                            Fname = "Ahmed",
                            Lname = "Tarek",
                            officeId = 5
                        });
                });

            modelBuilder.Entity("EF_Migration.Entities.Office", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("officeLocation")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("officeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.ToTable("Offices", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            officeLocation = "building A",
                            officeName = "Off_05"
                        },
                        new
                        {
                            Id = 2,
                            officeLocation = "building B",
                            officeName = "Off_12"
                        },
                        new
                        {
                            Id = 3,
                            officeLocation = "Adminstration",
                            officeName = "Off_32"
                        },
                        new
                        {
                            Id = 4,
                            officeLocation = "IT Department",
                            officeName = "Off_44"
                        },
                        new
                        {
                            Id = 5,
                            officeLocation = "IT Department",
                            officeName = "Off_43"
                        });
                });

            modelBuilder.Entity("EF_Migration.Entities.Instractor", b =>
                {
                    b.HasOne("EF_Migration.Entities.Office", "office")
                        .WithOne("instractor")
                        .HasForeignKey("EF_Migration.Entities.Instractor", "officeId");

                    b.Navigation("office");
                });

            modelBuilder.Entity("EF_Migration.Entities.Office", b =>
                {
                    b.Navigation("instractor");
                });
#pragma warning restore 612, 618
        }
    }
}
