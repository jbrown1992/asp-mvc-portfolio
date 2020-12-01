﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Options.Models;

namespace Options.Migrations
{
    [DbContext(typeof(OptionsDBContext))]
    [Migration("20201129115434_addSharePrice")]
    partial class addSharePrice
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Options.Models.Option", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AveragePrice")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Commission")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ExpiryDate")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Profit")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("StartDate")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("StockPriceAtSale")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("StrikePrice")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Symbol")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Options");
                });

            modelBuilder.Entity("Options.Models.Share", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AveragePrice")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CurrentPrice")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Exchange")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Quantity")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Return")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Symbol")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Shares");
                });

            modelBuilder.Entity("Options.Models.SharePrice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CurrentPrice")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastTimeCheck")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Symbol")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("SharePrice");
                });

            modelBuilder.Entity("Options.Models.Type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Types");
                });
#pragma warning restore 612, 618
        }
    }
}