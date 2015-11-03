namespace StudentsSystem.Api.Models
{
    using System.ComponentModel.DataAnnotations;

    public class CourseRequestModel
    {
        [Required]
        [MinLength(2)]
        [MaxLength(25)]
        public string Name { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(250)]
        public string Description { get; set; }       
    }
}