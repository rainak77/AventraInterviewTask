﻿// <auto-generated />
using AventraInterviewTask.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AventraInterviewTask.Migrations
{
    [DbContext(typeof(EventContext))]
    [Migration("20211014211415_new_property_Event_action_type")]
    partial class new_property_Event_action_type
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AventraInterviewTask.Models.EventActionItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EventActionType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EventCategoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EventCategoryId");

                    b.ToTable("EventActionItem");
                });

            modelBuilder.Entity("AventraInterviewTask.Models.EventActionProperty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EventActionItemId")
                        .HasColumnType("int");

                    b.Property<string>("EventActionType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EventCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("EventType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpectedHttpStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HttpMethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MailTemplate")
                        .HasColumnType("int");

                    b.Property<int>("MaxRecordsPerFile")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupportEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupportEmailCC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Validate")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("EventActionItemId");

                    b.HasIndex("EventCategoryId");

                    b.ToTable("EventActionProperty");
                });

            modelBuilder.Entity("AventraInterviewTask.Models.EventCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EventName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EventCategory");
                });

            modelBuilder.Entity("AventraInterviewTask.Models.EventActionItem", b =>
                {
                    b.HasOne("AventraInterviewTask.Models.EventCategory", "EventCategory")
                        .WithMany()
                        .HasForeignKey("EventCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EventCategory");
                });

            modelBuilder.Entity("AventraInterviewTask.Models.EventActionProperty", b =>
                {
                    b.HasOne("AventraInterviewTask.Models.EventActionItem", "EventActionItem")
                        .WithMany()
                        .HasForeignKey("EventActionItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AventraInterviewTask.Models.EventCategory", "EventCategory")
                        .WithMany()
                        .HasForeignKey("EventCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EventActionItem");

                    b.Navigation("EventCategory");
                });
#pragma warning restore 612, 618
        }
    }
}
