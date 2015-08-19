namespace School
{
    using System;
    using System.Text;

    public abstract class Person
    {
        private string name;
        private string textBlock;

        public Person(string inputName)
        {
            this.Name = inputName;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            protected set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Invalid name");
                }

                this.name = value;
            }
        }

        public string TextBlock
        {
            get
            {
                return this.textBlock;
            }

            set
            {
                this.textBlock = value;
            }
        }   
    
        public override string ToString()
        {
            var result = new StringBuilder();            
            return string.Format("Name:{0} Rank:{1}\n", this.Name.ToString(), this.GetType().Name);            
        }
    }
}