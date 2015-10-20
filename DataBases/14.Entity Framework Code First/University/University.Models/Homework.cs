namespace University.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Homework
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(500)]
        public string Content { get; set; }

        [Required]    
        public DateTime TimeSent { get; set; }        

        public virtual Course Course { get; set; }

        public virtual Student Student { get; set; }
    }
}
