﻿// <auto-generated />
using System;
using Data.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Core.Migrations
{
    [DbContext(typeof(BeeDbContext))]
    [Migration("20240824112502_mig10082024_11")]
    partial class mig10082024_11
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("Data.Core.Models.BeeQueen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeathDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("RaceId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RaceId");

                    b.ToTable("BeeQueen", (string)null);
                });

            modelBuilder.Entity("Data.Core.Models.Description", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Opiss");
                });

            modelBuilder.Entity("Data.Core.Models.DescriptionHiveReview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("OpisId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PrzegladId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UlId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OpisId")
                        .IsUnique();

                    b.HasIndex("PrzegladId");

                    b.HasIndex("UlId");

                    b.ToTable("DescriptionHiveReview", (string)null);
                });

            modelBuilder.Entity("Data.Core.Models.Hive", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("AddBeeQueenDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("BeeQueenId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsNucleus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Number")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BeeQueenId")
                        .IsUnique();

                    b.ToTable("Hive", (string)null);
                });

            modelBuilder.Entity("Data.Core.Models.Race", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("Higienicznosc")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Lagodnosc")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Licznosc")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Produktywnosc")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Rojliwosc")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Rasas");
                });

            modelBuilder.Entity("Data.Core.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("PlannedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("RealizedDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("ReviewTypeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ReviewTypeId");

                    b.ToTable("Review", (string)null);
                });

            modelBuilder.Entity("Data.Core.Models.ReviewType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ReviewTypes");
                });

            modelBuilder.Entity("Data.Core.Models.StanMagazynowy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Ilosc")
                        .HasColumnType("REAL");

                    b.Property<string>("Jednostka")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("StanMagazynowys");
                });

            modelBuilder.Entity("Data.Core.Models.BeeQueen", b =>
                {
                    b.HasOne("Data.Core.Models.Race", "Race")
                        .WithMany("BeeQueens")
                        .HasForeignKey("RaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Race");
                });

            modelBuilder.Entity("Data.Core.Models.DescriptionHiveReview", b =>
                {
                    b.HasOne("Data.Core.Models.Description", "Opis")
                        .WithOne("DescriptionHiveReview")
                        .HasForeignKey("Data.Core.Models.DescriptionHiveReview", "OpisId");

                    b.HasOne("Data.Core.Models.Review", "Przeglad")
                        .WithMany("DescriptionHiveReviews")
                        .HasForeignKey("PrzegladId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Core.Models.Hive", "Ul")
                        .WithMany("DescriptionHiveReviews")
                        .HasForeignKey("UlId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Opis");

                    b.Navigation("Przeglad");

                    b.Navigation("Ul");
                });

            modelBuilder.Entity("Data.Core.Models.Hive", b =>
                {
                    b.HasOne("Data.Core.Models.BeeQueen", "BeeQueen")
                        .WithOne("Hive")
                        .HasForeignKey("Data.Core.Models.Hive", "BeeQueenId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("BeeQueen");
                });

            modelBuilder.Entity("Data.Core.Models.Review", b =>
                {
                    b.HasOne("Data.Core.Models.ReviewType", "ReviewType")
                        .WithMany("Reviews")
                        .HasForeignKey("ReviewTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ReviewType");
                });

            modelBuilder.Entity("Data.Core.Models.BeeQueen", b =>
                {
                    b.Navigation("Hive")
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Core.Models.Description", b =>
                {
                    b.Navigation("DescriptionHiveReview")
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Core.Models.Hive", b =>
                {
                    b.Navigation("DescriptionHiveReviews");
                });

            modelBuilder.Entity("Data.Core.Models.Race", b =>
                {
                    b.Navigation("BeeQueens");
                });

            modelBuilder.Entity("Data.Core.Models.Review", b =>
                {
                    b.Navigation("DescriptionHiveReviews");
                });

            modelBuilder.Entity("Data.Core.Models.ReviewType", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
