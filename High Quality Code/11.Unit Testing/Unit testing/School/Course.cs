namespace MySchool
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Course
    {
        private string name;
        private List<Student> students;

        public Course(string name)
        {
            this.Name = name;
            this.students = new List<Student>();
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
                    throw new ArgumentNullException("Invalid name");
                }

                this.name = value;
            }
        }

        public List<Student> Students
        {
            get 
            { 
                return new List<Student>(this.students);
            }            
        } 
    
        public void AddStudent(Student student)
        {
            if (this.students.Count < 29)
            {
                this.students.Add(student);
            }           
        }

        public void RemoveStudent(Student student) 
        {
            bool isRemovedStudent = false;
            for (int i = 0; i < this.Students.Count; i++)
            {
                if (this.students[i].ID == student.ID && this.students[i].Name == student.Name) 
                {
                    isRemovedStudent = true;
                    this.students.RemoveAt(i);                    
                }
            }

            if (isRemovedStudent == false) 
            {
                throw new ArgumentOutOfRangeException("Invalid student!");
            }
        }
    }
}
