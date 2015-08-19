namespace School
{
    using System;
    using System.Collections.Generic;

    public class Student : Person, ITextBlock
    {
        private int classNumber;    

        public Student(string inputName, int inputClassNumber) : base(inputName)
        {
            this.ClassNumber = inputClassNumber;
        }

        public Student(string inputName, int inputClassNumber, string inputTextBlock)
            : this(inputName, inputClassNumber)
        {
            this.TextBlock = inputTextBlock;
        }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }

            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Invalid class number");
                }

                this.classNumber = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "Student Class Number:" + this.classNumber + "\nText Block:" + this.TextBlock;
        }   
    }
}
