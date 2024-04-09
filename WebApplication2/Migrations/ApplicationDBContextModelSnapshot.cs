﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication2.Data;

#nullable disable

namespace WebApplication2.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserClaims");
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
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("UserRoles");
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

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("WebApplication2.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "New York",
                            PostalCode = "10001",
                            State = "NY",
                            Street = "123 Main St"
                        },
                        new
                        {
                            Id = 2,
                            City = "Los Angeles",
                            PostalCode = "90001",
                            State = "CA",
                            Street = "456 Elm St"
                        },
                        new
                        {
                            Id = 3,
                            City = "Chicago",
                            PostalCode = "60601",
                            State = "IL",
                            Street = "789 Oak St"
                        },
                        new
                        {
                            Id = 4,
                            City = "Houston",
                            PostalCode = "77001",
                            State = "TX",
                            Street = "321 Pine St"
                        },
                        new
                        {
                            Id = 5,
                            City = "Miami",
                            PostalCode = "33101",
                            State = "FL",
                            Street = "567 Maple St"
                        },
                        new
                        {
                            Id = 6,
                            City = "Seattle",
                            PostalCode = "98101",
                            State = "WA",
                            Street = "890 Cedar St"
                        },
                        new
                        {
                            Id = 7,
                            City = "Boston",
                            PostalCode = "02101",
                            State = "MA",
                            Street = "234 Birch St"
                        },
                        new
                        {
                            Id = 8,
                            City = "San Francisco",
                            PostalCode = "94101",
                            State = "CA",
                            Street = "876 Walnut St"
                        });
                });

            modelBuilder.Entity("WebApplication2.Models.Club.Club", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<int>("ClubCategory")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("UserId");

                    b.ToTable("Clubs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressId = 2,
                            ClubCategory = 4,
                            Description = "For those who seek endurance challenges",
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                            Title = "Endurance Club",
                            UserId = 2
                        },
                        new
                        {
                            Id = 2,
                            AddressId = 5,
                            ClubCategory = 0,
                            Description = "For those who love speed and adrenaline",
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                            Title = "Speed Racing Club",
                            UserId = 3
                        },
                        new
                        {
                            Id = 3,
                            AddressId = 7,
                            ClubCategory = 2,
                            Description = "Exploring the great outdoors and challenging terrains",
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                            Title = "Adventure Club",
                            UserId = 2
                        },
                        new
                        {
                            Id = 4,
                            AddressId = 8,
                            ClubCategory = 3,
                            Description = "Promoting health and fitness through various activities",
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                            Title = "Fitness Club",
                            UserId = 3
                        });
                });

            modelBuilder.Entity("WebApplication2.Models.Race.Race", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EntryFee")
                        .HasColumnType("int");

                    b.Property<string>("Facebook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RaceCategory")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Twitter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("UserId");

                    b.ToTable("Races");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressId = 1,
                            Contact = "not yet",
                            Description = "Cross country race",
                            EntryFee = 500,
                            Facebook = "race face",
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                            RaceCategory = 2,
                            StartTime = new DateTime(2024, 4, 8, 2, 55, 21, 137, DateTimeKind.Local).AddTicks(5725),
                            Title = "formula 1",
                            Twitter = "@twiRace",
                            UserId = 1,
                            Website = "WWW.getRaceCourse"
                        },
                        new
                        {
                            Id = 2,
                            AddressId = 2,
                            Contact = "not yet",
                            Description = "country race",
                            EntryFee = 2000,
                            Facebook = "race face2",
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                            RaceCategory = 0,
                            StartTime = new DateTime(2024, 4, 8, 2, 55, 21, 137, DateTimeKind.Local).AddTicks(5842),
                            Title = "formula 1 pro",
                            Twitter = "@twiRace2",
                            UserId = 2,
                            Website = "WWW.getRaceCoursenew"
                        },
                        new
                        {
                            Id = 3,
                            AddressId = 3,
                            Contact = "Jane Doe",
                            Description = "Short-distance running race",
                            EntryFee = 1000,
                            Facebook = "SprintChallenge",
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                            RaceCategory = 4,
                            StartTime = new DateTime(2024, 4, 8, 3, 55, 21, 137, DateTimeKind.Local).AddTicks(5852),
                            Title = "Sprint Challenge",
                            Twitter = "@SprintChallenge",
                            UserId = 3,
                            Website = "www.sprintchallenge.com"
                        });
                });

            modelBuilder.Entity("WebApplication2.Models.User.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

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
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            AddressId = 3,
                            ConcurrencyStamp = "d12508ad-8eee-42d2-9582-b0ff02635d61",
                            Email = "Reb@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Rebecca Osuagwu",
                            Password = "jdahfaodao",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3a098fd3-ae5f-4d31-ba44-335484efa807",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = 2,
                            AccessFailedCount = 0,
                            AddressId = 4,
                            ConcurrencyStamp = "decaf520-3cf4-48a2-aa83-4dd806563867",
                            Email = "OwenHargereaves@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Owen Hagreaves",
                            Password = "owndealtio",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a9be1c5b-c947-4a06-bc5f-948b1f267fe7",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = 3,
                            AccessFailedCount = 0,
                            AddressId = 5,
                            ConcurrencyStamp = "4b67539a-108a-4bc6-a5f7-e647a5840788",
                            Email = "jane@example.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Matthew Oakson",
                            Password = "examplepassword2",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "eb2e8cf1-20d1-473d-9bea-4db184db15c5",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = 4,
                            AccessFailedCount = 0,
                            AddressId = 3,
                            ConcurrencyStamp = "df9a9eda-4f46-4df8-a396-3b755a706eab",
                            Email = "jane@example.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Matthew Oakson",
                            Password = "examplepassword2",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "09f6d716-87f3-4a38-ac0d-0ab54a41a423",
                            TwoFactorEnabled = false
                        });
                });

            modelBuilder.Entity("WebApplication2.Models.Club.Club", b =>
                {
                    b.HasOne("WebApplication2.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication2.Models.User.User", "User")
                        .WithMany("Clubs")
                        .HasForeignKey("UserId");

                    b.Navigation("Address");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApplication2.Models.Race.Race", b =>
                {
                    b.HasOne("WebApplication2.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication2.Models.User.User", null)
                        .WithMany("Races")
                        .HasForeignKey("UserId");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("WebApplication2.Models.User.User", b =>
                {
                    b.HasOne("WebApplication2.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("WebApplication2.Models.User.User", b =>
                {
                    b.Navigation("Clubs");

                    b.Navigation("Races");
                });
#pragma warning restore 612, 618
        }
    }
}
