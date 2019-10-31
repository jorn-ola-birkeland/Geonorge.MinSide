﻿// <auto-generated />
using System;
using Geonorge.MinSide.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Geonorge.MinSide.Infrastructure.Migrations
{
    [DbContext(typeof(OrganizationContext))]
    partial class OrganizationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Geonorge.MinSide.Infrastructure.Context.Document", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<string>("FileName");

                    b.Property<int?>("MeetingId");

                    b.Property<string>("Name");

                    b.Property<string>("OrganizationNumber");

                    b.Property<string>("Status");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("Date");

                    b.HasIndex("FileName")
                        .IsUnique()
                        .HasFilter("[FileName] IS NOT NULL");

                    b.HasIndex("MeetingId");

                    b.HasIndex("Name");

                    b.HasIndex("OrganizationNumber");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("Geonorge.MinSide.Infrastructure.Context.Meeting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Conclusion");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<string>("OrganizationNumber");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("Date");

                    b.HasIndex("OrganizationNumber");

                    b.ToTable("Meetings");
                });

            modelBuilder.Entity("Geonorge.MinSide.Infrastructure.Context.ToDo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment");

                    b.Property<DateTime>("Deadline");

                    b.Property<string>("Description");

                    b.Property<DateTime>("Done");

                    b.Property<int?>("MeetingId");

                    b.Property<int>("Number");

                    b.Property<string>("ResponsibleOrganization");

                    b.Property<string>("Status");

                    b.HasKey("Id");

                    b.HasIndex("MeetingId");

                    b.ToTable("Todo");
                });

            modelBuilder.Entity("Geonorge.MinSide.Infrastructure.Context.Document", b =>
                {
                    b.HasOne("Geonorge.MinSide.Infrastructure.Context.Meeting")
                        .WithMany("Documents")
                        .HasForeignKey("MeetingId");
                });

            modelBuilder.Entity("Geonorge.MinSide.Infrastructure.Context.ToDo", b =>
                {
                    b.HasOne("Geonorge.MinSide.Infrastructure.Context.Meeting")
                        .WithMany("ToDo")
                        .HasForeignKey("MeetingId");
                });
#pragma warning restore 612, 618
        }
    }
}
