﻿// <auto-generated />
using System;
using Data.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Core.Migrations
{
    [DbContext(typeof(BeeDbContext))]
    partial class BeeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("Data.Core.Models.MatkaPszczela", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataUrodzenia")
                        .HasColumnType("TEXT");

                    b.Property<string>("Opis")
                        .HasColumnType("TEXT");

                    b.Property<int>("RasaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RasaId");

                    b.ToTable("MatkaPszczela", (string)null);
                });

            modelBuilder.Entity("Data.Core.Models.Opis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tresc")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Opiss");
                });

            modelBuilder.Entity("Data.Core.Models.OpisUlPrzeglad", b =>
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

                    b.ToTable("OpisUlPrzeglad", (string)null);
                });

            modelBuilder.Entity("Data.Core.Models.Przeglad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Przeglads");
                });

            modelBuilder.Entity("Data.Core.Models.Rasa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Higienicznosc")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Lagodnosc")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Licznosc")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Opis")
                        .HasColumnType("TEXT");

                    b.Property<int>("Produktywnosc")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Rojliwosc")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Rasas");
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

            modelBuilder.Entity("Data.Core.Models.Ul", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("CzyOdklad")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DataPoddaniaMatki")
                        .HasColumnType("TEXT");

                    b.Property<int?>("MatkaPszczelaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Numer")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Opis")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MatkaPszczelaId")
                        .IsUnique();

                    b.ToTable("Ul", (string)null);
                });

            modelBuilder.Entity("Data.Core.Models.MatkaPszczela", b =>
                {
                    b.HasOne("Data.Core.Models.Rasa", "Rasa")
                        .WithMany("MatkaPszczelas")
                        .HasForeignKey("RasaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rasa");
                });

            modelBuilder.Entity("Data.Core.Models.OpisUlPrzeglad", b =>
                {
                    b.HasOne("Data.Core.Models.Opis", "Opis")
                        .WithOne("OpisUlPrzeglad")
                        .HasForeignKey("Data.Core.Models.OpisUlPrzeglad", "OpisId");

                    b.HasOne("Data.Core.Models.Przeglad", "Przeglad")
                        .WithMany("OpisUlPrzeglads")
                        .HasForeignKey("PrzegladId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Core.Models.Ul", "Ul")
                        .WithMany("OpisUlPrzeglads")
                        .HasForeignKey("UlId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Opis");

                    b.Navigation("Przeglad");

                    b.Navigation("Ul");
                });

            modelBuilder.Entity("Data.Core.Models.Ul", b =>
                {
                    b.HasOne("Data.Core.Models.MatkaPszczela", "MatkaPszczela")
                        .WithOne("Ul")
                        .HasForeignKey("Data.Core.Models.Ul", "MatkaPszczelaId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("MatkaPszczela");
                });

            modelBuilder.Entity("Data.Core.Models.MatkaPszczela", b =>
                {
                    b.Navigation("Ul")
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Core.Models.Opis", b =>
                {
                    b.Navigation("OpisUlPrzeglad")
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Core.Models.Przeglad", b =>
                {
                    b.Navigation("OpisUlPrzeglads");
                });

            modelBuilder.Entity("Data.Core.Models.Rasa", b =>
                {
                    b.Navigation("MatkaPszczelas");
                });

            modelBuilder.Entity("Data.Core.Models.Ul", b =>
                {
                    b.Navigation("OpisUlPrzeglads");
                });
#pragma warning restore 612, 618
        }
    }
}
