namespace ExceptionsHomework
{
    using System;

    public class SimpleMathExam : Exam
    {
        private const int MinNumberOfProblems = 0;
        private const int MaxNumberOfProblems = 10;
        private int problemsSolved;
        
        public SimpleMathExam(int problemsSolved)
        {
            this.ProblemsSolved = problemsSolved;
        }

        public int ProblemsSolved
        {
            get
            {
                return this.problemsSolved;
            }

            private set
            {
                if (value < MinNumberOfProblems || value > MaxNumberOfProblems)
                {
                    throw new ArgumentOutOfRangeException("Solved problems should be betwen 0 and 10");
                }

                this.problemsSolved = value;
            }
        }

        public override ExamResult Check()
        {
            return new ExamResult(this.ProblemsSolved, MinNumberOfProblems, MaxNumberOfProblems, "Exam results calculated by solved problems.");
        }
    }
}