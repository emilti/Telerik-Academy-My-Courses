namespace University.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Student
    {
        private ICollection<Homework> homeworks;

        private ICollection<Course> courses;

        public Student()
        {
            this.homeworks = new HashSet<Homework>();
            this.courses = new HashSet<Course>(); 
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]        
        public int Age { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        public string Address { get; set; }

        public virtual ICollection<Homework> Homeworks
        {
            get { return this.homeworks; }
            set { this.homeworks = value; }
        }

        public virtual ICollection<Course> Courses
        {
            get { return this.courses; }
            set { this.courses = value; }
        }
    }
}
