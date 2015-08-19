namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Course
    {
        private string name;
        private string teacherName;
        private List<string> students;

        public Course(string name)
        {
            this.Name = name;
            this.Students = new List<string>();
        }

        public Course(string name, string teacherName)
            : this(name)
        {
            this.TeacherName = teacherName;
        }

        public Course(string name, string teacherName, List<string> students)
            : this(name, teacherName)
        {
            this.Students = students;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                ValidateInputString(value);
                this.name = value;
            }
        }

        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            set
            {
                ValidateInputString(value);
                this.teacherName = value;
            }
        }
       
        public List<string> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                this.students = value;
            }
        }

        public void AddStudent(List<string> inputStudents)
        {
            for (int i = 0; i < inputStudents.Count; i++)
            {
                ValidateInputString(inputStudents[i]);
                this.students.Add(inputStudents[i]);
            }
        }

        public void AddStudent(string inputStudent)
        {         
                ValidateInputString(inputStudent);
                this.students.Add(inputStudent);           
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(this.Name);
            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());
            return result.ToString();
        }

        private static void ValidateInputString(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid input string!");
            }
        }

        private string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }
    }
}
