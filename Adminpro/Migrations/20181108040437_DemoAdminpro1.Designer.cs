﻿// <auto-generated />
using System;
using Adminpro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Adminpro.Migrations
{
    [DbContext(typeof(AdminproContext))]
    [Migration("20181108040437_DemoAdminpro1")]
    partial class DemoAdminpro1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Adminpro.Models.Student", b =>
                {
                    b.Property<string>("RollNumber")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Birthday");

                    b.Property<DateTime>("CreateAt");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<int>("Gender");

                    b.Property<string>("LastName");

                    b.Property<string>("Phone");

                    b.Property<int>("Status");

                    b.Property<DateTime>("UpdateAt");

                    b.HasKey("RollNumber");

                    b.ToTable("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
