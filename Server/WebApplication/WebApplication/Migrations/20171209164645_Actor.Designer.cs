﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using WebApplication.Data;

namespace WebApplication.Migrations
{
    [DbContext(typeof(DatabaseApplicationContext))]
    [Migration("20171209164645_Actor")]
    partial class Actor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("WebApplication.Data.Entities.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Actor");
                });

            modelBuilder.Entity("WebApplication.Data.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Rating");

                    b.Property<int>("ReleasedYear");

                    b.Property<decimal>("Sales");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Movie");
                });
#pragma warning restore 612, 618
        }
    }
}
