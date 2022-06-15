using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DepecheModeEntity.Models
{
    internal class DepecheModeSong
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //[Key] //Denna måste tas bort för att lägga till låt ska funka??????

        //[ForeignKey("AlbumId")]
        public int AlbumId { get; set; } // one to many
        public bool MusicVideo { get; set; }
    }
}