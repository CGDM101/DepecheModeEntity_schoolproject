using DepecheModeEntity.Models; // För att kunna använda klassen DepecheModeSong
using DepecheModeEntity.Database;
using Microsoft.EntityFrameworkCore; // 5.0.12!
using System;
using System.Collections.Generic;
using System.Text;

namespace DepecheModeEntity.Database
{
    internal class SongContext : DbContext // SongContext är databasklassen.
    {
        private const string DatabaseName = "DepecheModeSongs";
        public DbSet<DepecheModeSong> Songs { get; set; }
        public DbSet<DepecheModeAlbum> Albums { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($@"Server=(localdb)\mssqllocaldb;Database={DatabaseName};Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DepecheModeSong>().HasData(
                new DepecheModeSong { Id = 1, Name = "Enjoy the Silence", AlbumId = 7, MusicVideo = true },
                new DepecheModeSong { Id = 2, Name = "Barrel of a Gun", AlbumId = 9, MusicVideo = true },
                new DepecheModeSong { Id = 3, Name = "Lie to Me", AlbumId = 4, MusicVideo = true },
                new DepecheModeSong { Id = 4, Name = "Angel", AlbumId = 13, MusicVideo = true },
                new DepecheModeSong { Id = 5, Name = "Black Celebration", AlbumId = 5, MusicVideo = true },
                new DepecheModeSong { Id = 6, Name = "It doesn't matter", AlbumId = 4, MusicVideo = false },
                new DepecheModeSong { Id = 7, Name = "Sister of Night", AlbumId = 9, MusicVideo = false },
                new DepecheModeSong { Id = 8, Name = "Sweetest Condition", AlbumId = 10, MusicVideo = false },
                new DepecheModeSong { Id = 9, Name = "But Not Tonight", AlbumId = 5, MusicVideo = true },
                new DepecheModeSong { Id = 10, Name = "Nothing", AlbumId = 6, MusicVideo = false },
                new DepecheModeSong { Id = 11, Name = "Everything Counts", AlbumId = 3, MusicVideo = true },
                new DepecheModeSong { Id = 12, Name = "See You", AlbumId = 2, MusicVideo = true },
                new DepecheModeSong { Id = 13, Name = "Photographic", AlbumId = 1, MusicVideo = false },
                new DepecheModeSong { Id = 14, Name = "Nothing's Impossible", AlbumId = 11, MusicVideo = false },
                new DepecheModeSong { Id = 15, Name = "Rush", AlbumId = 8, MusicVideo = false },
                new DepecheModeSong { Id = 16, Name = "One Caress", AlbumId = 7, MusicVideo = false },
                new DepecheModeSong { Id = 17, Name = "Work Hard", AlbumId = 4, MusicVideo = false },
                new DepecheModeSong { Id = 18, Name = "Wrong", AlbumId = 12, MusicVideo = true },
                new DepecheModeSong { Id = 19, Name = "Where's the Revolution", AlbumId = 14, MusicVideo = true },
                new DepecheModeSong { Id = 20, Name = "Behind the Wheel", AlbumId = 6, MusicVideo = true }
                );

            modelBuilder.Entity<DepecheModeAlbum>().HasData(
                new DepecheModeAlbum { Id = 1, Name = "Speak & Spell", Year = 1981 },
                new DepecheModeAlbum { Id = 2, Name = "A Broken Frame", Year = 1982 },
                new DepecheModeAlbum { Id = 3, Name = "Construction Time Again", Year = 1983 },
                new DepecheModeAlbum { Id = 4, Name = "Some Great Reward", Year = 1984 },
                new DepecheModeAlbum { Id = 5, Name = "Black Celebration", Year = 1986 },
                new DepecheModeAlbum { Id = 6, Name = "Music for The Masses", Year = 1987 },
                new DepecheModeAlbum { Id = 7, Name = "Violator", Year = 1990 },
                new DepecheModeAlbum { Id = 8, Name = "Songs of Faith and Devotion", Year = 1993 },
                new DepecheModeAlbum { Id = 9, Name = "ULTRA", Year = 1997 },
                new DepecheModeAlbum { Id = 10, Name = "Exciter", Year = 2001 },
                new DepecheModeAlbum { Id = 11, Name = "Playing the Angel", Year = 2005 },
                new DepecheModeAlbum { Id = 12, Name = "Sounds of the Universe", Year = 2009 },
                new DepecheModeAlbum { Id = 13, Name = "Delta Machine", Year = 2013 },
                new DepecheModeAlbum { Id = 14, Name = "Spirit", Year = 2017 }
                );
        }
    }
}