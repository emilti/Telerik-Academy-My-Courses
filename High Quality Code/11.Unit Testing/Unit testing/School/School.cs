namespace MySchool
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class School
    {
        private string name;
        private List<Course> courses;

        public School(string name)
        {
            this.Name = name;
            this.courses = new List<Course>();
        }

        public List<Course> Courses
        {
            get
            {
                return new List<Course>(this.courses);
            }          
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid name");
                }

                this.name = value;
            }
        }

        public void AddCourse(Course course)
        {
            this.courses.Add(course);
        }
    }
}
