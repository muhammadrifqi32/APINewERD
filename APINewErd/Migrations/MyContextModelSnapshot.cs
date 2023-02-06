﻿// <auto-generated />
using System;
using APINewErd.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APINewErd.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("APINewErd.Models.Account", b =>
                {
                    b.Property<string>("NIK")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NIK");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("APINewErd.Models.AccountRole", b =>
                {
                    b.Property<string>("NIK")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Role_Id")
                        .HasColumnType("int");

                    b.HasKey("NIK", "Role_Id");

                    b.HasIndex("Role_Id");

                    b.ToTable("AccountRoles");
                });

            modelBuilder.Entity("APINewErd.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Manager_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Manager_Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("APINewErd.Models.Employee", b =>
                {
                    b.Property<string>("NIK")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Department_Id")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manager_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.HasKey("NIK");

                    b.HasIndex("Department_Id");

                    b.HasIndex("Manager_Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("APINewErd.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("APINewErd.Models.Account", b =>
                {
                    b.HasOne("APINewErd.Models.Employee", "Employee")
                        .WithOne("Account")
                        .HasForeignKey("APINewErd.Models.Account", "NIK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("APINewErd.Models.AccountRole", b =>
                {
                    b.HasOne("APINewErd.Models.Account", "Account")
                        .WithMany("AccountRoles")
                        .HasForeignKey("NIK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APINewErd.Models.Role", "Role")
                        .WithMany("AccountRoles")
                        .HasForeignKey("Role_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("APINewErd.Models.Department", b =>
                {
                    b.HasOne("APINewErd.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("Manager_Id");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("APINewErd.Models.Employee", b =>
                {
                    b.HasOne("APINewErd.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("Department_Id");

                    b.HasOne("APINewErd.Models.Employee", "Manager")
                        .WithMany()
                        .HasForeignKey("Manager_Id");

                    b.Navigation("Department");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("APINewErd.Models.Account", b =>
                {
                    b.Navigation("AccountRoles");
                });

            modelBuilder.Entity("APINewErd.Models.Employee", b =>
                {
                    b.Navigation("Account");
                });

            modelBuilder.Entity("APINewErd.Models.Role", b =>
                {
                    b.Navigation("AccountRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
