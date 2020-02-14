﻿// <auto-generated />
using System;
using MetricsDashboard.WebApi.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MetricsDashboard.WebApi.Migrations
{
    [DbContext(typeof(MetricsDbContext))]
    [Migration("20191120082144_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MetricsDashboard.WebApi.Entities.Metric", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Goal")
                        .HasColumnType("int");

                    b.Property<int>("Limit")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int?>("Wish")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Metrics");
                });

            modelBuilder.Entity("MetricsDashboard.WebApi.Entities.MetricHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("AddedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("MetricId")
                        .HasColumnType("int");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MetricId");

                    b.ToTable("MetricHistory");
                });

            modelBuilder.Entity("MetricsDashboard.WebApi.Entities.MetricHistory", b =>
                {
                    b.HasOne("MetricsDashboard.WebApi.Entities.Metric", "Metric")
                        .WithMany("History")
                        .HasForeignKey("MetricId");
                });
#pragma warning restore 612, 618
        }
    }
}