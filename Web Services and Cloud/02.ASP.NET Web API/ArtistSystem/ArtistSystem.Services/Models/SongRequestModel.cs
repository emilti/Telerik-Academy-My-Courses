namespace ArtistSystem.Services.Models
{
    using System.ComponentModel.DataAnnotations;

    public class SongRequestModel
    {
        [Required]
        public string Title { get; set; }

        public int Year { get; set; }        

        public string Genre { get; set; }        
    }
}