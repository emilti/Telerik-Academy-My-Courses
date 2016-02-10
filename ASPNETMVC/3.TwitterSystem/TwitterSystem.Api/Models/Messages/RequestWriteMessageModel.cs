namespace TwitterSystem.Api.Models.Messages
{
    using System.ComponentModel.DataAnnotations;

    public class RequestWriteMessageModel
    {
        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string Title { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(150)]
        public string Content { get; set; }     
    }
}