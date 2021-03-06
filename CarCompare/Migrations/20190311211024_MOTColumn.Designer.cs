﻿// <auto-generated />
using System;
using CarCompare.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarCompare.Migrations
{
    [DbContext(typeof(CarCompareContext))]
    [Migration("20190311211024_MOTColumn")]
    partial class MOTColumn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarCompare.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Colour");

                    b.Property<DateTime>("DateAdded");

                    b.Property<string>("Location");

                    b.Property<string>("Make");

                    b.Property<int>("Mileage");

                    b.Property<string>("Model");

                    b.Property<int>("MotExpiry");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("RegistrationMark");

                    b.Property<string>("TrimLevel");

                    b.Property<string>("Url");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.ToTable("Car");
                });
#pragma warning restore 612, 618
        }
    }
}
