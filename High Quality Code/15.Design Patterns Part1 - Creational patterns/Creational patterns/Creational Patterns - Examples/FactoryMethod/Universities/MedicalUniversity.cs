namespace CreationalPatterns
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MedicalUniversity : University
    {
        public override Student GetStudent()
        {
            var student = new Doctor { Specialty = "Medicine", Tax = 250, YearsOfEducation = 7 };
            return student;
        }
    }
}
