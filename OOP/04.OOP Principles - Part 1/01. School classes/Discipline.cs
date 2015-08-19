namespace School
{
    using System;

    public class Discipline : ITextBlock
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;
        private string textBlock;
        
        public Discipline(string inputName, int inputNumberOfLectures, int inputNumberOfExercises)
        {
            this.Name = inputName;
            this.NumberOfExercises = inputNumberOfExercises;
            this.NumberOfLectures = inputNumberOfLectures;          
        }

        public Discipline(string inputName, int inputNumberOfLectures, int inputNumberOfExercises, string inputTextBlock)
            : this(inputName, inputNumberOfLectures, inputNumberOfExercises)
        {
            this.TextBlock = inputTextBlock;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Invalid name");
                }

                this.name = value;
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid number of exercises");
                }

                this.numberOfExercises = value;
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid number of lectures");
                }

                this.numberOfLectures = value;
            }
        }

        public string TextBlock
        {
            get { return this.textBlock; }
            set { this.textBlock = value; }
        }

       public override string ToString()
       {    
           string result = string.Format(
               "Name:{0}\nNumber Of Lectures:{1}\nNumber of exercises:{2}\nText block:{3}",
               this.Name,
               this.NumberOfLectures,
               this.NumberOfExercises,
               this.TextBlock);
           return result;
       }        
    }
}
