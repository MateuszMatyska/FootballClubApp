﻿// <auto-generated />
using FootballClub.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace FootballClub.DAL.Migrations
{
    [DbContext(typeof(FootballClubDB))]
    [Migration("20180322222104_AddBasicInformations")]
    partial class AddBasicInformations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FootballClub.DAL.Models.BasicInformations", b =>
                {
                    b.Property<int>("InformationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Data");

                    b.Property<string>("Information");

                    b.HasKey("InformationId");

                    b.ToTable("BasicInformations");
                });
#pragma warning restore 612, 618
        }
    }
}
