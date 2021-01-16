﻿// <auto-generated />
using System;
using Definux.Emeraude.Logger;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Definux.Emeraude.Logger.Migrations
{
    [DbContext(typeof(LoggerContext))]
    [Migration("20210115002750_RemoveLoggerClass")]
    partial class RemoveLoggerClass
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10");

            modelBuilder.Entity("Definux.Emeraude.Domain.Logging.ActivityLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Action")
                        .HasColumnName("action")
                        .HasColumnType("TEXT");

                    b.Property<string>("Area")
                        .HasColumnName("area")
                        .HasColumnType("TEXT");

                    b.Property<string>("Controller")
                        .HasColumnName("controller")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnName("created_by")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnName("created_on")
                        .HasColumnType("TEXT");

                    b.Property<string>("Headers")
                        .HasColumnName("headers")
                        .HasColumnType("TEXT");

                    b.Property<string>("Method")
                        .HasColumnName("method")
                        .HasColumnType("TEXT");

                    b.Property<string>("Parameters")
                        .HasColumnName("parameters")
                        .HasColumnType("TEXT");

                    b.Property<string>("Route")
                        .HasColumnName("route")
                        .HasColumnType("TEXT");

                    b.Property<string>("TraceId")
                        .HasColumnName("trace_id")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserAgent")
                        .HasColumnName("user_agent")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("activity_logs");
                });

            modelBuilder.Entity("Definux.Emeraude.Domain.Logging.EmailLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Body")
                        .HasColumnName("body")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnName("created_by")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnName("created_on")
                        .HasColumnType("TEXT");

                    b.Property<string>("Receiver")
                        .HasColumnName("receiver")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Sent")
                        .HasColumnName("sent")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Subject")
                        .HasColumnName("subject")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("email_logs");
                });

            modelBuilder.Entity("Definux.Emeraude.Domain.Logging.ErrorLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CreatedBy")
                        .HasColumnName("created_by")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnName("created_on")
                        .HasColumnType("TEXT");

                    b.Property<string>("Message")
                        .HasColumnName("message")
                        .HasColumnType("TEXT");

                    b.Property<string>("Method")
                        .HasColumnName("method")
                        .HasColumnType("TEXT");

                    b.Property<string>("Source")
                        .HasColumnName("source")
                        .HasColumnType("TEXT");

                    b.Property<string>("StackTrace")
                        .HasColumnName("stack_trace")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("error_logs");
                });

            modelBuilder.Entity("Definux.Emeraude.Domain.Logging.TempFileLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Applied")
                        .HasColumnName("applied")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CreatedBy")
                        .HasColumnName("created_by")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnName("created_on")
                        .HasColumnType("TEXT");

                    b.Property<int>("FileExtension")
                        .HasColumnName("file_extension")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FileType")
                        .HasColumnName("file_type")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Path")
                        .HasColumnName("path")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("temp_file_logs");
                });
#pragma warning restore 612, 618
        }
    }
}
