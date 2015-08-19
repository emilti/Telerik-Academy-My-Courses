namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class LocalCourse : Course
    {
        private string lab;

        public LocalCourse(string name) : base(name)
        {            
        }

        public LocalCourse(string courseName, string teacherName) : base(courseName, teacherName)
        {           
        }

        public LocalCourse(string courseName, string teacherName, List<string> students) : base(courseName, teacherName, students)
        {
        }       

        public string Lab
        {
            get
            {
                return this.lab;
            }

            set
            {
                ValidateInputString(value);
                this.lab = value;
            }
        }       

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("LocalCourse { Name = ");
            result.Append(base.ToString());
            if (this.Lab != null)
            {
                result.Append("; Lab = ");
                result.Append(this.Lab);
            }

            result.Append(" }");
            return result.ToString();
        }

        private static void ValidateInputString(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid input string!");
            }
        }
    }
}
