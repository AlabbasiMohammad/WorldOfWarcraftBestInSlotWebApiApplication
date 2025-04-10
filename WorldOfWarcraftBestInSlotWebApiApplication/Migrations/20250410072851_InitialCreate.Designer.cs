﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WorldOfWarcraftBestInSlotWebApiApplication.Data;

#nullable disable

namespace WorldOfWarcraftBestInSlotWebApiApplication.Migrations
{
    [DbContext(typeof(PostgresqlDbService))]
    [Migration("20250410072851_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WorldOfWarcraftBestInSlotWebApiApplication.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("WorldOfWarcraftBestInSlotWebApiApplication.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Agility")
                        .HasColumnType("integer");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<int>("CharacterId")
                        .HasColumnType("integer");

                    b.Property<int>("MonsterId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Stamina")
                        .HasColumnType("integer");

                    b.Property<int>("Strength")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CharacterId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("WorldOfWarcraftBestInSlotWebApiApplication.Models.ItemCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ItemId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ItemCategories");
                });

            modelBuilder.Entity("WorldOfWarcraftBestInSlotWebApiApplication.Models.Monster", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<decimal>("DropItemChance")
                        .HasColumnType("numeric");

                    b.Property<int>("ItemId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ItemId")
                        .IsUnique();

                    b.ToTable("Monsters");
                });

            modelBuilder.Entity("WorldOfWarcraftBestInSlotWebApiApplication.Models.Item", b =>
                {
                    b.HasOne("WorldOfWarcraftBestInSlotWebApiApplication.Models.ItemCategory", "Category")
                        .WithMany("Items")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("WorldOfWarcraftBestInSlotWebApiApplication.Models.Character", "Character")
                        .WithMany("Items")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Character");
                });

            modelBuilder.Entity("WorldOfWarcraftBestInSlotWebApiApplication.Models.Monster", b =>
                {
                    b.HasOne("WorldOfWarcraftBestInSlotWebApiApplication.Models.Item", "Item")
                        .WithOne("Monster")
                        .HasForeignKey("WorldOfWarcraftBestInSlotWebApiApplication.Models.Monster", "ItemId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Item");
                });

            modelBuilder.Entity("WorldOfWarcraftBestInSlotWebApiApplication.Models.Character", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("WorldOfWarcraftBestInSlotWebApiApplication.Models.Item", b =>
                {
                    b.Navigation("Monster")
                        .IsRequired();
                });

            modelBuilder.Entity("WorldOfWarcraftBestInSlotWebApiApplication.Models.ItemCategory", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
