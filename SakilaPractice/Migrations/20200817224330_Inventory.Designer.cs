﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SakilaPractice.Data;

namespace SakilaPractice.Migrations
{
    [DbContext(typeof(SakilaPracticeContext))]
    [Migration("20200817224330_Inventory")]
    partial class Inventory
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SakilaPractice.Models.film_actor", b =>
                {
                    b.Property<int>("actor_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("film_id");

                    b.Property<DateTime>("last_update");

                    b.HasKey("actor_id");

                    b.ToTable("film_actor");
                });

            modelBuilder.Entity("SakilaPractice.Models.film_category", b =>
                {
                    b.Property<int>("film_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("category_id");

                    b.Property<DateTime>("last_update");

                    b.HasKey("film_id");

                    b.ToTable("film_category");
                });

            modelBuilder.Entity("SakilaPractice.Models.Inventory", b =>
                {
                    b.Property<int>("inventory_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("film_id");

                    b.Property<DateTime>("last_update");

                    b.Property<int>("store_id");

                    b.HasKey("inventory_id");

                    b.ToTable("Inventory");
                });
#pragma warning restore 612, 618
        }
    }
}
