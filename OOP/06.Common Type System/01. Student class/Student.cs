namespace Student
{
    using System;
    
    public class Student : ICloneable, IComparable<Student>
    {
        // PROBLEM 1
        private string firstName;
        private string middleName;
        private string lastName;       
        private string permanentAddress;
        private string mobilePhone;
        private string email;
        private string course;
       
        public Student(
            string inputFName, 
            string inputMName,
            string inputLName,
            int inputSSN, 
            string inputAddress,
            string inputMPhone,
            string inputEmail, 
            string inputCourse, 
            SpecialtyEnum inputSp,
            UniversityEnum inputUn,
            FacultyEnum inputFac)
        {
            this.FirstName = inputFName;
            this.MiddleName = inputMName;
            this.LastName = inputLName;
            this.SSN = inputSSN;
            this.PermanentAddress = inputAddress;
            this.MobilePhone = inputMPhone;
            this.Email = inputEmail;
            this.Course = inputCourse;
            this.Specialty = inputSp;
            this.University = inputUn;
            this.Faculty = inputFac;
        }

        public int SSN { get; private set; }

        public SpecialtyEnum Specialty { get; private set; }

        public UniversityEnum University { get; private set; }

        public FacultyEnum Faculty { get; private set; }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name can't be null.");
                }

                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Middle name can't be null.");
                }

                this.middleName = value;
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name can't be null.");
                }

                this.lastName = value;
            }
        }

        public string PermanentAddress
        {
            get
            {
                return this.permanentAddress;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Address can't be null.");
                }

                this.permanentAddress = value;
            }
        }

        public string MobilePhone
        {
            get
            {
                return this.mobilePhone;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Mobile phone can't be null.");
                }

                this.mobilePhone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Email can't be null.");
                }

                this.email = value;
            }
        }

        public string Course
        {
            get
            {
                return this.course;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Course can't be null.");
                }

                this.course = value;
            }
        }

        public override bool Equals(object b)
        {
            if (!(b is Student))
            {
                throw new ArgumentException("Passed objects are not students.");
            }

            if (b is Student)
            {
                var d = b as Student;
                if (d.FirstName.CompareTo(this.FirstName) == 0 &&
                    d.MiddleName.CompareTo(this.MiddleName) == 0 &&
                    d.LastName.CompareTo(this.LastName) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Student a, Student b)
        {
            if (!(a is Student && b is Student))
            {
                throw new ArgumentException("Passed objects are not students.");
            }

            if (b.FirstName.CompareTo(a.FirstName) == 0 &&
                b.MiddleName.CompareTo(a.MiddleName) == 0 &&
                b.LastName.CompareTo(a.LastName) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Student a, Student b)
        {
             if (!(a is Student && b is Student))
            {
                throw new ArgumentException("Passed objects are not students.");
            }

            if (b.FirstName.CompareTo(a.FirstName) != 0 ||
                b.MiddleName.CompareTo(a.MiddleName) != 0 ||
                b.LastName.CompareTo(a.LastName) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {  
            return this.firstName.GetHashCode() ^ this.middleName.GetHashCode() ^ this.LastName.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format(
                "First Name:{0}\nMiddle Name:{1}\nLast name:{2}\nSSN:{3}\nAddress:{4}\nMobile Phone:{5}\nEmail:{6}\nSpecialty:{7}\nUniversity:{8}\nFaculty:{9}",
                this.FirstName,
                this.MiddleName,
                this.LastName, 
                this.SSN, 
                this.PermanentAddress, 
                this.MobilePhone, 
                this.Email,
                this.Specialty,
                this.University, 
                this.Faculty);
        }

        // PROBLEM 2
        public object Clone()
        {
            Student newSt = this.MemberwiseClone() as Student;
            return newSt = new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.PermanentAddress, this.MobilePhone, this.Email, this.Course, this.Specialty, this.University, this.Faculty);
        }

        // PROBLEM 3
        public int CompareTo(Student b)
        {
            var a = this.FirstName + this.MiddleName + this.LastName;
            var c = b.FirstName + b.MiddleName + b.LastName;
            if (c.CompareTo(a) == 0)
            {
                return this.SSN.CompareTo(b.SSN);
            }
            else
            {
                return a.CompareTo(c);
            }
        }
    }
}