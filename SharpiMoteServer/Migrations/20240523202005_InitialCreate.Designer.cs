﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SharpiMoteServer.Data;

#nullable disable

namespace SharpiMoteServer.Migrations
{
    [DbContext(typeof(SharpiMoteServerDbContext))]
    [Migration("20240523202005_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SharpiMoteServer.Models.User", b =>
                {
                    b.Property<Guid>("CLIENT_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CODE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("HASH")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("IP_ADDR")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CLIENT_ID");

                    b.ToTable("CLIENTS");
                });
#pragma warning restore 612, 618
        }
    }
}