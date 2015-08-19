namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class School
    {
        private List<ClassInSchool> listOfClasses;

        public School()
        {
            this.listOfClasses = new List<ClassInSchool>();
        }

        public List<ClassInSchool> ListOfClasses
        {
            get
            {
                return new List<ClassInSchool>(this.listOfClasses);
            }           
        }

        public void AddClass(ClassInSchool newClass)
        {
            this.listOfClasses.Add(newClass);
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            foreach (var classInSchool in this.listOfClasses)
            {
                result.AppendLine(classInSchool.ToString());
            }

            return base.ToString();
        }
    }
}
