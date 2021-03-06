﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nitrogen.Data.Mysql.Data;

namespace Nitrogen.Data.Mysql.Migrations
{
    [DbContext(typeof(MySqlDbContext))]
    [Migration("20200122095204_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Nitrogen.Model.Permissions", b =>
                {
                    b.Property<Guid>("PermissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreateUser")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<bool>("DeleteMark")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Depth")
                        .HasColumnType("int");

                    b.Property<bool>("EnabledMark")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Expanded")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Icon")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<bool>("IsLeaf")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("LastUpdateDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("LastUpdateUser")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<int>("Left")
                        .HasColumnType("int");

                    b.Property<string>("PermissionCode")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<string>("PermissionName")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<Guid>("PermissionsCategoryId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Right")
                        .HasColumnType("int");

                    b.Property<int>("SortCode")
                        .HasColumnType("int");

                    b.Property<string>("UrlAddress")
                        .HasColumnType("varchar(150) CHARACTER SET utf8mb4")
                        .HasMaxLength(150);

                    b.HasKey("PermissionId");

                    b.HasIndex("PermissionsCategoryId");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("Nitrogen.Model.PermissionsCategory", b =>
                {
                    b.Property<Guid>("PermissionsCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("PermissionCategoryCode")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PermissionsCategoryName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("PermissionsCategoryId");

                    b.ToTable("PermissionsCategories");
                });

            modelBuilder.Entity("Nitrogen.Model.Permissions", b =>
                {
                    b.HasOne("Nitrogen.Model.PermissionsCategory", "PermissionsCategory")
                        .WithMany()
                        .HasForeignKey("PermissionsCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
