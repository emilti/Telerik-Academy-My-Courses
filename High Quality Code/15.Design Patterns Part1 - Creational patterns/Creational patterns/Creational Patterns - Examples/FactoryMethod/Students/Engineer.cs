namespace CreationalPatterns
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Engineer : Student
    {
        public Engineer()
        {
            this.Skill = "Math";
        }

        public string Skill { get; set; }
    }
}
