namespace Students
{
    using System;
    using System.Collections.Generic;  
  
    public class Student
    {
        private string firstName;
        private string lastName;
        private string fn;
        private string tel;
        private string email;        
        private List<int> marks;
        private int groupNumber;

        public Student(
            string inputFName, 
            string inputLName,
            string inputFN,
            string inputTel,
              string inputEmail,
            List<int> inputMarks, 
            int inputGroupNumber)
        {
            this.FirstName = inputFName;
            this.LastName = inputLName;
            this.FN = inputFN;
            this.Tel = inputTel;
            this.Email = inputEmail;
            this.Marks = inputMarks;
            this.GroupNumber = inputGroupNumber;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("Invalid first name");
                }

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
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("Invalid last name");
                }

                this.lastName = value;
            }
        }

        public string FN
        {
            get
            {
                return this.fn;
            }

            private set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("Invalid FN");
                }

                this.fn = value;
            }
        }

        public string Tel
        {
            get
            {
                return this.tel;
            }

            private set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("Invalid tel");
                }

                this.tel = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            private set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("Invalid Email");
                }

                this.email = value;
            }
        }

        public List<int> Marks
        {
            get
            {
                return this.marks;
            }

            private set
            {                
                this.marks = value;
            }
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }

            private set
            {
                this.groupNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
}