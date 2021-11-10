﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WolvenKit.Common.Model.Database;

namespace WolvenKit.Common.Migrations
{
    [DbContext(typeof(RedDBContext))]
    [Migration("20211017163123_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("WolvenKit.Common.Model.Database.RedFile", b =>
                {
                    b.Property<ulong>("RedFileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Archive")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("UsedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("Uses")
                        .HasColumnType("TEXT");

                    b.HasKey("RedFileId");

                    b.ToTable("Files");
                });
#pragma warning restore 612, 618
        }
    }
}