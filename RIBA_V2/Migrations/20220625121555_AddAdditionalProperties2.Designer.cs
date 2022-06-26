﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RIBA_V2;

namespace RIBA_V2.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220625121555_AddAdditionalProperties2")]
    partial class AddAdditionalProperties2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("RIBA_V2.Entities+Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Jacob"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Aidan"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Lexy"
                        });
                });

            modelBuilder.Entity("RIBA_V2.Entities+Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("OrderDescription")
                        .HasColumnType("TEXT");

                    b.Property<int>("TotalCost")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Order");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 1,
                            DateTime = new DateTime(2029, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderDescription = "Big Order For Jacob",
                            TotalCost = 0
                        },
                        new
                        {
                            Id = 2,
                            CustomerId = 2,
                            DateTime = new DateTime(2015, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderDescription = "Big Order For Aidan",
                            TotalCost = 0
                        },
                        new
                        {
                            Id = 3,
                            CustomerId = 3,
                            DateTime = new DateTime(2022, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderDescription = "Big Order For Lexy",
                            TotalCost = 0
                        });
                });

            modelBuilder.Entity("RIBA_V2.Entities+OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ItemName")
                        .HasColumnType("TEXT");

                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UnitPrice")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItem");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ItemName = "Wood",
                            OrderId = 1,
                            Quantity = 10,
                            UnitPrice = 5
                        },
                        new
                        {
                            Id = 2,
                            ItemName = "Steel",
                            OrderId = 2,
                            Quantity = 10,
                            UnitPrice = 12
                        },
                        new
                        {
                            Id = 3,
                            ItemName = "Wool",
                            OrderId = 3,
                            Quantity = 10,
                            UnitPrice = 5
                        });
                });

            modelBuilder.Entity("RIBA_V2.Entities+Order", b =>
                {
                    b.HasOne("RIBA_V2.Entities+Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RIBA_V2.Entities+OrderItem", b =>
                {
                    b.HasOne("RIBA_V2.Entities+Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
