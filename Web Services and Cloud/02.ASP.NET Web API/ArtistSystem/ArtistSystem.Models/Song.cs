﻿namespace ArtistSystem.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Song
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public int Year { get; set; }

        public string Genre { get; set; }       
    }
}
