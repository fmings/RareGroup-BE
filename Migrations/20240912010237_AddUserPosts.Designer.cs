﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RareGroup_BE;

#nullable disable

namespace RareGroup_BE.Migrations
{
    [DbContext(typeof(RareGroup_BEDbContext))]
    [Migration("20240912010237_AddUserPosts")]
    partial class AddUserPosts
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PostTag", b =>
                {
                    b.Property<int>("PostsId")
                        .HasColumnType("integer");

                    b.Property<int>("TagsId")
                        .HasColumnType("integer");

                    b.HasKey("PostsId", "TagsId");

                    b.HasIndex("TagsId");

                    b.ToTable("PostTag");
                });

            modelBuilder.Entity("RareGroup_BE.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Label = "Comedy"
                        },
                        new
                        {
                            Id = 2,
                            Label = "Shopping"
                        },
                        new
                        {
                            Id = 3,
                            Label = "Music"
                        },
                        new
                        {
                            Id = 4,
                            Label = "Sports"
                        },
                        new
                        {
                            Id = 5,
                            Label = "Motivational"
                        });
                });

            modelBuilder.Entity("RareGroup_BE.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Approved")
                        .HasColumnType("boolean");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("PublicationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Approved = true,
                            CategoryId = 1,
                            Content = "Hello World, how are you today?",
                            ImageUrl = "https://static1.squarespace.com/static/5e949a92e17d55230cd1d44f/t/61f35a8548933c4ce4cc0daa/1643338381475/HelloLight_Mac.png?format=1500w",
                            PublicationDate = new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Hello World",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Approved = false,
                            CategoryId = 2,
                            Content = "Hello Zach, doing well?",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/e7/Zach_Galifianakis_2012_%28cropped%29.jpg",
                            PublicationDate = new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Hello Zach",
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            Approved = true,
                            CategoryId = 3,
                            Content = "Hello Brit, how's work?",
                            ImageUrl = "https://www.rollingstone.com/wp-content/uploads/2022/02/AdeleBritsRedCarpet-1.jpeg",
                            PublicationDate = new DateTime(2024, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Hello Brit",
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            Approved = true,
                            CategoryId = 4,
                            Content = "Hello Fletcher, you are turning 21 this year!",
                            ImageUrl = "https://www.denofgeek.com/wp-content/uploads/2020/08/chevy-chase-fletch-universal-pictures.jpg?fit=1200%2C680",
                            PublicationDate = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Hello Fletcher",
                            UserId = 4
                        },
                        new
                        {
                            Id = 5,
                            Approved = false,
                            CategoryId = 5,
                            Content = "Hello Lola, stop pooping on the bed",
                            ImageUrl = "https://i.imgur.com/bS6aYJ5.jpg",
                            PublicationDate = new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Hello Lola",
                            UserId = 5
                        },
                        new
                        {
                            Id = 6,
                            Approved = true,
                            CategoryId = 1,
                            Content = "Hello World, how are you today?",
                            ImageUrl = "https://static1.squarespace.com/static/5e949a92e17d55230cd1d44f/t/61f35a8548933c4ce4cc0daa/1643338381475/HelloLight_Mac.png?format=1500w",
                            PublicationDate = new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Hello World 2",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("RareGroup_BE.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Label = "#photooftheday"
                        },
                        new
                        {
                            Id = 2,
                            Label = "#likeforlike"
                        },
                        new
                        {
                            Id = 3,
                            Label = "#food"
                        },
                        new
                        {
                            Id = 4,
                            Label = "#music"
                        },
                        new
                        {
                            Id = 5,
                            Label = "#amazing"
                        });
                });

            modelBuilder.Entity("RareGroup_BE.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<bool>("IsStaff")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Uid")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            Bio = "The Island Gyal",
                            CreatedOn = new DateTime(2022, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "britnayg@gmail.com",
                            FirstName = "Britnay",
                            IsStaff = false,
                            LastName = "Gore",
                            Uid = ""
                        },
                        new
                        {
                            Id = 2,
                            Active = true,
                            Bio = "Team Vibes",
                            CreatedOn = new DateTime(2023, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "feliciam@gmail.com",
                            FirstName = "Felicia",
                            IsStaff = false,
                            LastName = "Mings",
                            Uid = ""
                        },
                        new
                        {
                            Id = 3,
                            Active = true,
                            Bio = "The Young Manager",
                            CreatedOn = new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "fletcherm@gmail.com",
                            FirstName = "Fletcher",
                            IsStaff = false,
                            LastName = "Moore",
                            Uid = ""
                        },
                        new
                        {
                            Id = 4,
                            Active = true,
                            Bio = "The Alcohol King",
                            CreatedOn = new DateTime(2022, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "colburn.zach7@gmail.com",
                            FirstName = "Zach",
                            IsStaff = false,
                            LastName = "Colburn",
                            Uid = ""
                        },
                        new
                        {
                            Id = 5,
                            Active = true,
                            Bio = "Backend Genius",
                            CreatedOn = new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "odij@gmail.com",
                            FirstName = "Odi",
                            IsStaff = false,
                            LastName = "Joseph",
                            Uid = ""
                        });
                });

            modelBuilder.Entity("PostTag", b =>
                {
                    b.HasOne("RareGroup_BE.Models.Post", null)
                        .WithMany()
                        .HasForeignKey("PostsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RareGroup_BE.Models.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RareGroup_BE.Models.Post", b =>
                {
                    b.HasOne("RareGroup_BE.Models.Category", "Categories")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RareGroup_BE.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categories");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
