namespace TwitterSystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Message
    {
        public int Id { get; set; }
        
        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string Title { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(150)]
        public string Content { get; set; }

        public string AuthorId { get; set; }

        public AppUser Author { get; set; }
      
        public DateTime CreatedOn { get; set; }

    }
}
