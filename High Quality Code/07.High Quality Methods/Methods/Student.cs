namespace Methods
{
    using System;

    public class Student
    {
        private string firstName;
        private string lastName;
        private string otherInfo;
        private DateTime birthDate;

        public Student()
        {
        }

        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName; 
        }

        public string FirstName 
        {
            get
            {
                return this.firstName;
            }

            set
            {
                this.ValidateName(value);
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                this.ValidateName(value);
                this.lastName = value;
            }
        }

         public string OtherInfo 
        {
            get
            {
                return this.otherInfo;
            }

            set
            {
                this.otherInfo = value;                
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return this.birthDate;
            }

            set
            {
                this.birthDate = value;
            }
        }
          
        public bool IsOlderThan(Student other)
        {
           return this.BirthDate < other.BirthDate;           
        }

        private void ValidateName(string value)
        {
            if (value.Length < 2)
            {
                throw new ArgumentException("Invalid name");
            }
        }
    }
}
