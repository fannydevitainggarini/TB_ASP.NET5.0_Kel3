﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Warungcd.Data;

namespace Warungcd.Migrations
{
    [DbContext(typeof(WarungCdContext))]
    partial class WarungCdContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Warungcd.Models.Barang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Deskripsi")
                        .HasColumnType("TEXT");

                    b.Property<int>("Harga")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NamaBarang")
                        .HasColumnType("TEXT");

                    b.Property<string>("UrlGambar")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Barang");
                });
#pragma warning restore 612, 618
        }
    }
}
