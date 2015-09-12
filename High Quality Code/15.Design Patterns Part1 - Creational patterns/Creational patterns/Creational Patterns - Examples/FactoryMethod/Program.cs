namespace CreationalPatterns
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            EducateStudent(new TechicalUniversity());
            EducateStudent(new MedicalUniversity());    
        }

        private static void EducateStudent(University university)
        {
            var student = university.GetStudent();    
        }    
    }
}
