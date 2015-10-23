﻿namespace University.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Course
    {
        private ICollection<Homework> homeworks;

        private ICollection<Student> students;

        public Course()
        {
            this.homeworks = new HashSet<Homework>();
            this.students = new HashSet<Student>();
        }

        public int CourseId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

       
        [MaxLength(50)]
        public string Desctiption { get; set; }

        public virtual ICollection<Homework> Homeworks
        {
            get { return this.homeworks; }
            set { this.homeworks = value; }
        }

        public virtual ICollection<Student> Students
        {
            get { return this.students; }
            set { this.students = value; }
        }
    }
}