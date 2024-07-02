﻿// <auto-generated />
using System;
using EquityAfia.UserManagement.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EquityAfia.UserManagement.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EquityAfia.UserManagement.Domain.RolesAndTypesAggregate.RolesAndTypesEntity.PractitionerType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PractitionerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PractitionerId");

                    b.HasIndex("TypeId");

                    b.ToTable("PractitionerTypes");
                });

            modelBuilder.Entity("EquityAfia.UserManagement.Domain.RolesAndTypesAggregate.RolesAndTypesEntity.Role", b =>
                {
                    b.Property<Guid>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("EquityAfia.UserManagement.Domain.RolesAndTypesAggregate.RolesAndTypesEntity.UserRole", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("EquityAfia.UserManagement.Domain.RolesAndTypesAggregate.RolesAndTypesEntity.UserType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserTypes");
                });

            modelBuilder.Entity("EquityAfia.UserManagement.Domain.UserAggregate.UsersEntities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DateOfBirth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Is2FAEnabled")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAccountVerified")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsInitialPasswordChanged")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPasswordExpired")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LicenseNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResetToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("UserType").HasValue("USER");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("EquityAfia.UserManagement.Domain.UserAggregate.UsersEntities.CHP", b =>
                {
                    b.HasBaseType("EquityAfia.UserManagement.Domain.UserAggregate.UsersEntities.User");

                    b.HasDiscriminator().HasValue("CHP");
                });

            modelBuilder.Entity("EquityAfia.UserManagement.Domain.UserAggregate.UsersEntities.Editor", b =>
                {
                    b.HasBaseType("EquityAfia.UserManagement.Domain.UserAggregate.UsersEntities.User");

                    b.HasDiscriminator().HasValue("Editor");
                });

            modelBuilder.Entity("EquityAfia.UserManagement.Domain.UserAggregate.UsersEntities.Patient", b =>
                {
                    b.HasBaseType("EquityAfia.UserManagement.Domain.UserAggregate.UsersEntities.User");

                    b.HasDiscriminator().HasValue("PATIENT");
                });

            modelBuilder.Entity("EquityAfia.UserManagement.Domain.UserAggregate.UsersEntities.Practitioner", b =>
                {
                    b.HasBaseType("EquityAfia.UserManagement.Domain.UserAggregate.UsersEntities.User");

                    b.HasDiscriminator().HasValue("PRACTITIONER");
                });

            modelBuilder.Entity("EquityAfia.UserManagement.Domain.RolesAndTypesAggregate.RolesAndTypesEntity.PractitionerType", b =>
                {
                    b.HasOne("EquityAfia.UserManagement.Domain.UserAggregate.UsersEntities.Practitioner", "Practitioner")
                        .WithMany("PractitionerTypes")
                        .HasForeignKey("PractitionerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EquityAfia.UserManagement.Domain.RolesAndTypesAggregate.RolesAndTypesEntity.UserType", "Type")
                        .WithMany("PractitionerTypes")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Practitioner");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("EquityAfia.UserManagement.Domain.RolesAndTypesAggregate.RolesAndTypesEntity.UserRole", b =>
                {
                    b.HasOne("EquityAfia.UserManagement.Domain.UserAggregate.UsersEntities.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EquityAfia.UserManagement.Domain.RolesAndTypesAggregate.RolesAndTypesEntity.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EquityAfia.UserManagement.Domain.RolesAndTypesAggregate.RolesAndTypesEntity.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("EquityAfia.UserManagement.Domain.RolesAndTypesAggregate.RolesAndTypesEntity.UserType", b =>
                {
                    b.Navigation("PractitionerTypes");
                });

            modelBuilder.Entity("EquityAfia.UserManagement.Domain.UserAggregate.UsersEntities.User", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("EquityAfia.UserManagement.Domain.UserAggregate.UsersEntities.Practitioner", b =>
                {
                    b.Navigation("PractitionerTypes");
                });
#pragma warning restore 612, 618
        }
    }
}
