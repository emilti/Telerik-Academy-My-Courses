namespace ArtistSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Artist
    {
        private ICollection<Album> albums;

        public Artist()
        {
            this.albums = new HashSet<Album>();          
        }

        public int Id { get; set; }
      
        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public string Country { get; set; }

        public DateTime DateOfBirth { get; set; }

        public virtual ICollection<Album> Albums
        {
            get { return this.albums; }
            set { this.albums = value; }
        }
    }
}
