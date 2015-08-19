namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class OffsiteCourse : Course
    {
        private string town;

        public OffsiteCourse(string name) : base(name)
        {                      
        }

        public OffsiteCourse(string courseName, string teacherName) : base(courseName, teacherName)            
        {       
        }

        public OffsiteCourse(string courseName, string teacherName, List<string> students) : base(courseName, teacherName, students)
        {           
        }  

        public string Town
        {
            get
            {
                return this.town;
            }

            set
            {
                ValidateInputString(value);
                this.town = value;
            }
        }
        
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("OffsiteCourse { Name = ");
            result.Append(base.ToString());
            if (this.Town != null)
            {
                result.Append("; Town = ");
                result.Append(this.Town);
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
