﻿// <auto-generated />
using DepecheModeEntity.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DepecheModeEntity.Migrations
{
    [DbContext(typeof(SongContext))]
    [Migration("20220615122108_FirstCreation")]
    partial class FirstCreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DepecheModeEntity.Models.DepecheModeAlbum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Speak & Spell",
                            Year = 1981
                        },
                        new
                        {
                            Id = 2,
                            Name = "A Broken Frame",
                            Year = 1982
                        },
                        new
                        {
                            Id = 3,
                            Name = "Construction Time Again",
                            Year = 1983
                        },
                        new
                        {
                            Id = 4,
                            Name = "Some Great Reward",
                            Year = 1984
                        },
                        new
                        {
                            Id = 5,
                            Name = "Black Celebration",
                            Year = 1986
                        },
                        new
                        {
                            Id = 6,
                            Name = "Music for The Masses",
                            Year = 1987
                        },
                        new
                        {
                            Id = 7,
                            Name = "Violator",
                            Year = 1990
                        },
                        new
                        {
                            Id = 8,
                            Name = "Songs of Faith and Devotion",
                            Year = 1993
                        },
                        new
                        {
                            Id = 9,
                            Name = "ULTRA",
                            Year = 1997
                        },
                        new
                        {
                            Id = 10,
                            Name = "Exciter",
                            Year = 2001
                        },
                        new
                        {
                            Id = 11,
                            Name = "Playing the Angel",
                            Year = 2005
                        },
                        new
                        {
                            Id = 12,
                            Name = "Sounds of the Universe",
                            Year = 2009
                        },
                        new
                        {
                            Id = 13,
                            Name = "Delta Machine",
                            Year = 2013
                        },
                        new
                        {
                            Id = 14,
                            Name = "Spirit",
                            Year = 2017
                        });
                });

            modelBuilder.Entity("DepecheModeEntity.Models.DepecheModeSong", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<bool>("MusicVideo")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AlbumId = 7,
                            MusicVideo = true,
                            Name = "Enjoy the Silence"
                        },
                        new
                        {
                            Id = 2,
                            AlbumId = 9,
                            MusicVideo = true,
                            Name = "Barrel of a Gun"
                        },
                        new
                        {
                            Id = 3,
                            AlbumId = 4,
                            MusicVideo = true,
                            Name = "Lie to Me"
                        },
                        new
                        {
                            Id = 4,
                            AlbumId = 13,
                            MusicVideo = true,
                            Name = "Angel"
                        },
                        new
                        {
                            Id = 5,
                            AlbumId = 5,
                            MusicVideo = true,
                            Name = "Black Celebration"
                        },
                        new
                        {
                            Id = 6,
                            AlbumId = 4,
                            MusicVideo = false,
                            Name = "It doesn't matter"
                        },
                        new
                        {
                            Id = 7,
                            AlbumId = 9,
                            MusicVideo = false,
                            Name = "Sister of Night"
                        },
                        new
                        {
                            Id = 8,
                            AlbumId = 10,
                            MusicVideo = false,
                            Name = "Sweetest Condition"
                        },
                        new
                        {
                            Id = 9,
                            AlbumId = 5,
                            MusicVideo = true,
                            Name = "But Not Tonight"
                        },
                        new
                        {
                            Id = 10,
                            AlbumId = 6,
                            MusicVideo = false,
                            Name = "Nothing"
                        },
                        new
                        {
                            Id = 11,
                            AlbumId = 3,
                            MusicVideo = true,
                            Name = "Everything Counts"
                        },
                        new
                        {
                            Id = 12,
                            AlbumId = 2,
                            MusicVideo = true,
                            Name = "See You"
                        },
                        new
                        {
                            Id = 13,
                            AlbumId = 1,
                            MusicVideo = false,
                            Name = "Photographic"
                        },
                        new
                        {
                            Id = 14,
                            AlbumId = 11,
                            MusicVideo = false,
                            Name = "Nothing's Impossible"
                        },
                        new
                        {
                            Id = 15,
                            AlbumId = 8,
                            MusicVideo = false,
                            Name = "Rush"
                        },
                        new
                        {
                            Id = 16,
                            AlbumId = 7,
                            MusicVideo = false,
                            Name = "One Caress"
                        },
                        new
                        {
                            Id = 17,
                            AlbumId = 4,
                            MusicVideo = false,
                            Name = "Work Hard"
                        },
                        new
                        {
                            Id = 18,
                            AlbumId = 12,
                            MusicVideo = true,
                            Name = "Wrong"
                        },
                        new
                        {
                            Id = 19,
                            AlbumId = 14,
                            MusicVideo = true,
                            Name = "Where's the Revolution"
                        },
                        new
                        {
                            Id = 20,
                            AlbumId = 6,
                            MusicVideo = true,
                            Name = "Behind the Wheel"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}