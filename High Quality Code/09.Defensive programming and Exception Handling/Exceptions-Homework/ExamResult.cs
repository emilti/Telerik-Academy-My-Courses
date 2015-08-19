namespace ExceptionsHomework
{
    using System;

    public class ExamResult
    {
        private int grade;
        private int minGrade;
        private int maxGrade;
        private string comments;

        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
        {
            this.Grade = grade;
            this.MinGrade = minGrade;
            this.MaxGrade = maxGrade;
            this.Comments = comments;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The grade should be positive!");
                }

                this.grade = value;
            }
        }

        public int MinGrade
        {
            get
            {
                return this.minGrade;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The minGrade should be positive!");
                }

                this.minGrade = value;
            }
        }

        public int MaxGrade
        {
            get
            {
                return this.maxGrade;
            }

            private set
            {
                if (value <= this.minGrade)
                {
                    throw new Exception("minGrade should be smaller than maxGrade");
                }

                this.maxGrade = value;
            }
        }

        public string Comments
        {
            get
            {
                return this.comments;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Comments can not be blank");
                }

                this.comments = value;
            }
        }
    }
}