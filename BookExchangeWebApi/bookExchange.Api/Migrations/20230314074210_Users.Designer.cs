﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using bookExchange.Api.Data;

#nullable disable

namespace bookExchange.Api.Migrations
{
    [DbContext(typeof(BooksContext))]
    [Migration("20230314074210_Users")]
    partial class Users
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("bookExchange.Api.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AddedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("bookExchange.Api.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "KenyattaNolan42@gmail.com",
                            Name = "Kenyatta Nolan"
                        },
                        new
                        {
                            Id = 2,
                            Email = "FedericoHyatt.Skiles@hotmail.com",
                            Name = "Federico Hyatt"
                        },
                        new
                        {
                            Id = 3,
                            Email = "DiamondKris.Russel@yahoo.com",
                            Name = "Diamond Kris"
                        },
                        new
                        {
                            Id = 4,
                            Email = "BaileyKreiger64@yahoo.com",
                            Name = "Bailey Kreiger"
                        },
                        new
                        {
                            Id = 5,
                            Email = "HilbertFerry.Metz@yahoo.com",
                            Name = "Hilbert Ferry"
                        },
                        new
                        {
                            Id = 6,
                            Email = "JoelProsacco58@hotmail.com",
                            Name = "Joel Prosacco"
                        },
                        new
                        {
                            Id = 7,
                            Email = "DoyleAbbott10@hotmail.com",
                            Name = "Doyle Abbott"
                        },
                        new
                        {
                            Id = 8,
                            Email = "ZettaBatz.Hahn71@gmail.com",
                            Name = "Zetta Batz"
                        },
                        new
                        {
                            Id = 9,
                            Email = "DomenicaPollich_Jacobson@hotmail.com",
                            Name = "Domenica Pollich"
                        },
                        new
                        {
                            Id = 10,
                            Email = "MyaBechtelar0@hotmail.com",
                            Name = "Mya Bechtelar"
                        });
                });

            modelBuilder.Entity("bookExchange.Api.Models.Book", b =>
                {
                    b.HasOne("bookExchange.Api.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}