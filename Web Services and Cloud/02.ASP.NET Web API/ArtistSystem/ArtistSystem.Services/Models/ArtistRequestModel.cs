namespace ArtistSystem.Services.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class ArtistRequestModel
    {
        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public string Country { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}