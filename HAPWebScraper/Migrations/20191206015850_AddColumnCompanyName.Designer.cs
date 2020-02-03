﻿// <auto-generated />
using System;
using HAPWebScraper.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HAPWebScraper.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20191206015850_AddColumnCompanyName")]
    partial class AddColumnCompanyName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HAPWebScraper.Models.StockData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("Change");

                    b.Property<string>("CompanyName");

                    b.Property<decimal?>("PE");

                    b.Property<decimal?>("PercentChange");

                    b.Property<decimal?>("Price");

                    b.Property<DateTime>("ScrapeDate");

                    b.Property<string>("Symbol");

                    b.Property<decimal?>("Volume");

                    b.Property<decimal?>("YTDChange");

                    b.HasKey("Id");

                    b.ToTable("StocksData");
                });
#pragma warning restore 612, 618
        }
    }
}