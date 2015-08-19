namespace ExceptionsHomework
{
    using System;

    public class CSharpExam : Exam
    {
        private const int MinCSharpScore = 0;
        private const int MaxCSharpScore = 100;

        private int score;

        public CSharpExam(int score)
        {
            this.Score = score;
        }

        public int Score
        {
            get
            {
                return this.score;
            }

            private set
            {
                if (value < MinCSharpScore || value > MaxCSharpScore)
                {
                    throw new ArgumentException("Score should be betwen 0 and 100");
                }

                this.score = value;
            }
        }

        public override ExamResult Check()
        {
            return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
        }
    }
}
