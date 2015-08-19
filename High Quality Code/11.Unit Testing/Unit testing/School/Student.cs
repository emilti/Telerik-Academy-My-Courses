namespace MySchool
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {
        private const int MINID = 10000;
        private const int MAXID = 99999;
        private string name;
        private int id;        
       
        public Student(string name, int id)
        {
            this.Name = name;
            this.ID = id;
        }

        public string Name
        {
            get
            {
                return this.name; 
            }

            set 
            {
                if (string.IsNullOrEmpty(value)) 
                {
                    throw new ArgumentException("Invalid name!");
                }

                this.name = value; 
            }
        }        

        public int ID
        {
            get 
            {
                return this.id; 
            }

            set 
            {
                if (value < MINID || value > MAXID)
                {
                    throw new ArgumentException("Invalid ID!");
                }

                this.id = value; 
            }
        }
    }
}
