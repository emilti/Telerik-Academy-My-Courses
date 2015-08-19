namespace Task0304
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;

        public Student(string inputFName, string inputLName, int inputAge)
        {
            this.FirstName = inputFName;
            this.LastName = inputLName;
            this.Age = inputAge;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                CheckName(value);
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                CheckName(value);
                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid Age.");
                }

                this.age = value;
            }
        }

        public static void CheckName(string value)
        {
             if (value.Length == 0)
                {
                    throw new ArgumentNullException("Invalid name");
                }
        }

        public override string ToString()
        {
           return string.Format("{0} {1}", this.firstName, this.lastName);
        }
    }
}