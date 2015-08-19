namespace School
{
    using System.Collections.Generic;
    using System.Text;

    public class Teacher : Person, ITextBlock
    {
        private List<Discipline> listOfDisciplines;
        private string textBlock;       
        
        public Teacher(string inputName)
            : base(inputName)
            {                            
                this.listOfDisciplines = new List<Discipline>();
            }

        public Teacher(string inputName, string inputTextBlock)
            : this(inputName)
        {
            this.textBlock = inputTextBlock;
        }

        public List<Discipline> ListOfDisciplines
        {
            get 
            {
                return new List<Discipline>(this.listOfDisciplines);
            }            
        }

        public string TextBlock
        {
            get 
            { 
                return this.textBlock; 
            }

            private set 
            { 
                this.textBlock = value;
            }
        }

        public void AddDisicipline(Discipline newDiscipline)
        {
            this.listOfDisciplines.Add(newDiscipline);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            foreach (Discipline disc in this.listOfDisciplines)
            {
                result.AppendLine(disc.ToString());
            }

            return base.ToString() + "Text Block:" + this.TextBlock + "\n" + result.ToString();
        }        
    }
}
