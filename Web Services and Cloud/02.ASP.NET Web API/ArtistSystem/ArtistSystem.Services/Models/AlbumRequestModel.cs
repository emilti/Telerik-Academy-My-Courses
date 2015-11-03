namespace ArtistSystem.Services.Models
{
    using System.ComponentModel.DataAnnotations;

    public class AlbumRequestModel
    {
        [Required]
        public string Title { get; set; }

        public int Year { get; set; }

        public string Producer { get; set; }

        public decimal Price { get; set; }
    }
}