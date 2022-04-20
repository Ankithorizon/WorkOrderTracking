﻿// <auto-generated />
using System;
using EF.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EF.Core.Migrations
{
    [DbContext(typeof(WorkOrderTrackingContext))]
    partial class WorkOrderTrackingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EF.Core.Models.CustomerOrder", b =>
                {
                    b.Property<int>("CustomerOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("OrderDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("OrderDueDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int?>("OrderQuantity")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("ProductDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerOrderId");

                    b.ToTable("CustomerOrders");
                });

            modelBuilder.Entity("EF.Core.Models.Operation", b =>
                {
                    b.Property<int>("OperationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OpQTYDone")
                        .HasColumnType("int");

                    b.Property<int?>("OpQTYRequired")
                        .HasColumnType("int");

                    b.Property<DateTime?>("OperationEndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OperationNumber")
                        .HasColumnType("int");

                    b.Property<DateTime?>("OperationStartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OperationStatus")
                        .HasColumnType("int");

                    b.Property<int?>("WorkOrderId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("OperationId");

                    b.HasIndex("WorkOrderId");

                    b.HasIndex("OperationNumber", "WorkOrderId")
                        .IsUnique();

                    b.ToTable("Operations");
                });

            modelBuilder.Entity("EF.Core.Models.OperationToPart", b =>
                {
                    b.Property<int>("OperationToPartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("OperationId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("PartId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("XFERQTY")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("OperationToPartId");

                    b.HasIndex("OperationId");

                    b.HasIndex("PartId", "OperationId")
                        .IsUnique();

                    b.ToTable("OperationToParts");
                });

            modelBuilder.Entity("EF.Core.Models.Operator", b =>
                {
                    b.Property<int>("OperatorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OperatorId");

                    b.ToTable("Operators");
                });

            modelBuilder.Entity("EF.Core.Models.OperatorActivity", b =>
                {
                    b.Property<int>("OperatorActivityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<TimeSpan?>("CycleTime")
                        .HasColumnType("time");

                    b.Property<DateTime?>("OpPauseRunTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("OpQtyDone")
                        .HasColumnType("int");

                    b.Property<DateTime?>("OpStartRunTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("OperationId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("OperationNumber")
                        .HasColumnType("int");

                    b.Property<int>("OperationStatus")
                        .HasColumnType("int");

                    b.Property<int?>("OperatorId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("WorkOrderId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("OperatorActivityId");

                    b.HasIndex("OperatorId");

                    b.ToTable("OperatorActivities");
                });

            modelBuilder.Entity("EF.Core.Models.Part", b =>
                {
                    b.Property<int>("PartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Qty")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("PartId");

                    b.ToTable("Parts");
                });

            modelBuilder.Entity("EF.Core.Models.WorkOrder", b =>
                {
                    b.Property<int>("WorkOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerOrderId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("StatusNote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("WorkOrderEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("WorkOrderStartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("WorkOrderStatus")
                        .HasColumnType("int");

                    b.HasKey("WorkOrderId");

                    b.HasIndex("CustomerOrderId")
                        .IsUnique();

                    b.ToTable("WorkOrders");
                });

            modelBuilder.Entity("EF.Core.Models.Operation", b =>
                {
                    b.HasOne("EF.Core.Models.WorkOrder", "WorkOrder")
                        .WithMany("Operations")
                        .HasForeignKey("WorkOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EF.Core.Models.OperationToPart", b =>
                {
                    b.HasOne("EF.Core.Models.Operation", "Operation")
                        .WithMany("OperationToParts")
                        .HasForeignKey("OperationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF.Core.Models.Part", "Part")
                        .WithMany("OperationToParts")
                        .HasForeignKey("PartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EF.Core.Models.OperatorActivity", b =>
                {
                    b.HasOne("EF.Core.Models.Operator", "Operator")
                        .WithMany("OperatorActivities")
                        .HasForeignKey("OperatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EF.Core.Models.WorkOrder", b =>
                {
                    b.HasOne("EF.Core.Models.CustomerOrder", "CustomerOrder")
                        .WithOne("WorkOrder")
                        .HasForeignKey("EF.Core.Models.WorkOrder", "CustomerOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
