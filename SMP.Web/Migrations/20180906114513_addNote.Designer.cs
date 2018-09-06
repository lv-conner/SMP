﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SMP.ApplicationContext;

namespace SMP.Web.Migrations
{
    [DbContext(typeof(SMPContext))]
    [Migration("20180906114513_addNote")]
    partial class addNote
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SMP.ApplicationContext.Entity.Note", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreateDate");

                    b.Property<string>("DateNote")
                        .IsRequired()
                        .HasMaxLength(4000)
                        .IsUnicode(true);

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("Note");
                });

            modelBuilder.Entity("SMP.ApplicationContext.Entity.Register", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreateDate");

                    b.Property<DateTime?>("RegisterDate");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("Register");
                });
#pragma warning restore 612, 618
        }
    }
}
