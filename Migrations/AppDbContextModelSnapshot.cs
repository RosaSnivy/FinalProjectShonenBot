﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using final.Models;

#nullable disable

namespace FinalProjectShonenBot.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("final.Models.Anime", b =>
                {
                    b.Property<int>("AnimeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AnimeName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AnimeID");

                    b.ToTable("Animes");
                });

            modelBuilder.Entity("final.Models.Character", b =>
                {
                    b.Property<int>("CharacterID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AnimeID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CharImageURL")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CharacterName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Durability")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HP")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Strength")
                        .HasColumnType("INTEGER");

                    b.HasKey("CharacterID");

                    b.HasIndex("AnimeID");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("final.Models.Character", b =>
                {
                    b.HasOne("final.Models.Anime", "Anime")
                        .WithMany("Characters")
                        .HasForeignKey("AnimeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Anime");
                });

            modelBuilder.Entity("final.Models.Anime", b =>
                {
                    b.Navigation("Characters");
                });
#pragma warning restore 612, 618
        }
    }
}