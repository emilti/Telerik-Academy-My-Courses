namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ClassInSchool : ITextBlock
    {
        private List<Student> studentsCollection;
        private List<Teacher> teachersCollection;
        private string textIdentifier;

        private string textBlock;

        public ClassInSchool(string inputText)
        {
            this.studentsCollection = new List<Student>();
            this.teachersCollection = new List<Teacher>();
            this.TextIdentifier = inputText;
        }

        public ClassInSchool(string inputText, string inputTextBlock)
            : this(inputText)
        {
            this.studentsCollection = new List<Student>();
            this.teachersCollection = new List<Teacher>();
            this.TextBlock = inputTextBlock;
        }

        public List<Student> StudentsCollection
        {
            get
            {
                return new List<Student>(this.studentsCollection);
            }
        }

        public List<Teacher> TeachersCollection
        {
            get
            {
                return new List<Teacher>(this.teachersCollection);
            }
        }

        public string TextIdentifier
        {
            get
            {
                return this.textIdentifier;
            }

            private set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Invalid text identifier");
                }

                this.textIdentifier = value;
            }
        }

        public string TextBlock
        {
            get
            {
                return this.textBlock;
            }

            set
            {
                this.textBlock = value;
            }
        }

        public void AddTeacher(Teacher newTeacher)
        {
            this.teachersCollection.Add(newTeacher);
        }

        public void RemoveTeacher(int indexOfTeacher)
        {
            this.teachersCollection.RemoveAt(indexOfTeacher);
        }

        public void AddStudent(Student newStudent)
        {
            this.studentsCollection.Add(newStudent);
        }

        public void RemoveStudent(Student student)
        {
            for (var i = 0; i < this.StudentsCollection.Count; i++)
            {
                if (student.ClassNumber == this.studentsCollection[i].ClassNumber)
                {
                    this.studentsCollection.RemoveAt(i);
                }
            }
        }

        public override string ToString()
        {
            var resultStudents = new StringBuilder();
            var resultTeachers = new StringBuilder();
        
            foreach (var teacher in this.teachersCollection)
            {
                resultTeachers.AppendLine(teacher.ToString());
            }

            foreach (var student in this.studentsCollection)
            {
                resultStudents.AppendLine(student.ToString());
            }

            return string.Format(
                "Class text identifier:{0} \ntext block:{1} \nTeachers\n{2}\nStudents:\n{3}", 
                this.TextIdentifier,
                this.TextBlock, 
                resultTeachers.ToString(),
                resultStudents.ToString());
        }
    }
}
