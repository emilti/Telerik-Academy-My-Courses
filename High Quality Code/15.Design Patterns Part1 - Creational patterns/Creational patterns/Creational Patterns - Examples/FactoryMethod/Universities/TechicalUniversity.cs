namespace CreationalPatterns
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TechicalUniversity : University
    {
        public override Student GetStudent()
        {
            var student = new Engineer { Specialty = "Engineering", Tax = 200, YearsOfEducation = 5 };
            return student;
        }
    }
}
