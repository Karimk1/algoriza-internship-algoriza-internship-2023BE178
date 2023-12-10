﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Services;

#nullable disable

namespace Services.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231203215520_requestUpdate")]
    partial class requestUpdate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Core.Models.Appointment", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<float>("Time")
                        .HasColumnType("real");

                    b.Property<int>("day")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("DoctorId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("Core.Models.Coupon", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("Discoundvalue")
                        .HasColumnType("int");

                    b.Property<string>("discoundCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("discoundType")
                        .HasColumnType("int");

                    b.Property<int>("requestNumber")
                        .HasColumnType("int");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.Property<int>("usage")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("coupons");
                });

            modelBuilder.Entity("Core.Models.Doctor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("SpecializeId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("numberOfRequests")
                        .HasColumnType("int");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.HasIndex("SpecializeId");

                    b.HasIndex("UserId");

                    b.ToTable("doctors");
                });

            modelBuilder.Entity("Core.Models.Requests", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("couponid")
                        .HasColumnType("int");

                    b.Property<int>("doctorId")
                        .HasColumnType("int");

                    b.Property<int>("finalPrice")
                        .HasColumnType("int");

                    b.Property<int>("pationtId")
                        .HasColumnType("int");

                    b.Property<string>("pationtId1")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("requestDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("requestType")
                        .HasColumnType("int");

                    b.Property<int>("timeid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("couponid");

                    b.HasIndex("doctorId");

                    b.HasIndex("pationtId1");

                    b.HasIndex("timeid");

                    b.ToTable("requests");
                });

            modelBuilder.Entity("Core.Models.Specialize", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("numberOfRequest")
                        .HasColumnType("int");

                    b.Property<string>("specializeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("specializes");

                    b.HasData(
                        new
                        {
                            id = 1,
                            numberOfRequest = 0,
                            specializeName = "Immunologists"
                        },
                        new
                        {
                            id = 2,
                            numberOfRequest = 0,
                            specializeName = "Cardiologists"
                        },
                        new
                        {
                            id = 3,
                            numberOfRequest = 0,
                            specializeName = "Dermatologists"
                        },
                        new
                        {
                            id = 4,
                            numberOfRequest = 0,
                            specializeName = "Endocrinologists"
                        },
                        new
                        {
                            id = 5,
                            numberOfRequest = 0,
                            specializeName = "Gastroenterologists"
                        },
                        new
                        {
                            id = 6,
                            numberOfRequest = 0,
                            specializeName = "Hematologists"
                        },
                        new
                        {
                            id = 7,
                            numberOfRequest = 0,
                            specializeName = "Internists"
                        },
                        new
                        {
                            id = 8,
                            numberOfRequest = 0,
                            specializeName = "Nephrologists"
                        },
                        new
                        {
                            id = 9,
                            numberOfRequest = 0,
                            specializeName = "Neurologists"
                        },
                        new
                        {
                            id = 10,
                            numberOfRequest = 0,
                            specializeName = "Obstetricians and Gynecologists"
                        },
                        new
                        {
                            id = 11,
                            numberOfRequest = 0,
                            specializeName = "Oncologists"
                        },
                        new
                        {
                            id = 12,
                            numberOfRequest = 0,
                            specializeName = "Ophthalmologists"
                        },
                        new
                        {
                            id = 13,
                            numberOfRequest = 0,
                            specializeName = "Osteopaths"
                        },
                        new
                        {
                            id = 14,
                            numberOfRequest = 0,
                            specializeName = "Otolaryngologists"
                        },
                        new
                        {
                            id = 15,
                            numberOfRequest = 0,
                            specializeName = "Pediatricians"
                        },
                        new
                        {
                            id = 16,
                            numberOfRequest = 0,
                            specializeName = "Psychiatrists"
                        },
                        new
                        {
                            id = 17,
                            numberOfRequest = 0,
                            specializeName = "Rheumatologists"
                        },
                        new
                        {
                            id = 18,
                            numberOfRequest = 0,
                            specializeName = "Urologists"
                        });
                });

            modelBuilder.Entity("Core.Models.Time", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("Day")
                        .HasColumnType("int");

                    b.Property<int>("appointmentid")
                        .HasColumnType("int");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.Property<double>("time")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.HasIndex("appointmentid");

                    b.ToTable("times");
                });

            modelBuilder.Entity("Core.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("dateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("gender")
                        .HasColumnType("int");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "657dc2f1-d9e3-4ae4-aafd-8f444d64fa04",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f7d29f87-e088-4d00-b868-363a7d38c237",
                            Email = "KarimKamel@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumber = "012586444825",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "534978d0-0e19-486b-8857-f640542635c5",
                            TwoFactorEnabled = false,
                            UserName = "karimkamel",
                            dateOfBirth = new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            gender = 1,
                            role = 1
                        },
                        new
                        {
                            Id = "53fce3c2-16d8-455f-9868-55b0a6eec735",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c8d375ab-36c6-4eb7-b333-c2f005cca6c4",
                            Email = "Karimahmed@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumber = "012545455825",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "536f2654-8e6f-4b4c-900a-6bd309d5f530",
                            TwoFactorEnabled = false,
                            UserName = "karimAhmed",
                            dateOfBirth = new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            gender = 1,
                            role = 2
                        },
                        new
                        {
                            Id = "00821b57-c41a-4958-a811-7dad29621f0c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c9182bee-a8f4-46dc-aef2-9ef6a6788256",
                            Email = "Karim@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumber = "012586444825",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "562783ac-30e8-43cf-9056-64b166bcbfb3",
                            TwoFactorEnabled = false,
                            UserName = "karim",
                            dateOfBirth = new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            gender = 1,
                            role = 2
                        },
                        new
                        {
                            Id = "e9687e35-ee50-4d71-afe1-cb9ed3b46560",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "73bccd32-e12e-4c12-b707-8ca82076d3e0",
                            Email = "SaraKamel@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumber = "012586444825",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2277fd82-8ac4-4666-810c-083390e8a88e",
                            TwoFactorEnabled = false,
                            UserName = "Sarakamel",
                            dateOfBirth = new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            gender = 0,
                            role = 0
                        },
                        new
                        {
                            Id = "0b8c58ae-bfef-4d34-b7a7-6387bf7d27cd",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3c4eb3ce-e13d-4515-a74d-f9734ea891cf",
                            Email = "Karimsssail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumber = "012586444825",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b685478d-ca84-494a-b4dc-adfa314321f3",
                            TwoFactorEnabled = false,
                            UserName = "karimssss",
                            dateOfBirth = new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            gender = 1,
                            role = 0
                        },
                        new
                        {
                            Id = "3810e331-7be9-424b-a843-d5642bc50a3e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6510ddbb-e219-478a-b369-c47c038f7e00",
                            Email = "ahmedsssail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumber = "012586444825",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "cd9bdb27-191e-4f96-9c57-4574dca5e95c",
                            TwoFactorEnabled = false,
                            UserName = "Ahmed",
                            dateOfBirth = new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            gender = 1,
                            role = 0
                        },
                        new
                        {
                            Id = "156183a4-f41c-4126-b99e-860e2bc51aed",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "37c9a414-1683-4e3c-9101-0b0456430119",
                            Email = "Karimssddsail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumber = "012586444825",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "97cc1e17-b351-445c-af67-75f4213e53e3",
                            TwoFactorEnabled = false,
                            UserName = "karimssdddss",
                            dateOfBirth = new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            gender = 1,
                            role = 2
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Core.Models.Appointment", b =>
                {
                    b.HasOne("Core.Models.Doctor", "doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("doctor");
                });

            modelBuilder.Entity("Core.Models.Doctor", b =>
                {
                    b.HasOne("Core.Models.Specialize", "Specialize")
                        .WithMany()
                        .HasForeignKey("SpecializeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Specialize");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Core.Models.Requests", b =>
                {
                    b.HasOne("Core.Models.Coupon", "coupon")
                        .WithMany()
                        .HasForeignKey("couponid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Models.Doctor", "doctor")
                        .WithMany()
                        .HasForeignKey("doctorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Core.Models.User", "pationt")
                        .WithMany()
                        .HasForeignKey("pationtId1")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Core.Models.Time", "time")
                        .WithMany()
                        .HasForeignKey("timeid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("coupon");

                    b.Navigation("doctor");

                    b.Navigation("pationt");

                    b.Navigation("time");
                });

            modelBuilder.Entity("Core.Models.Time", b =>
                {
                    b.HasOne("Core.Models.Appointment", "appointment")
                        .WithMany()
                        .HasForeignKey("appointmentid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("appointment");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Core.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Core.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Core.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}