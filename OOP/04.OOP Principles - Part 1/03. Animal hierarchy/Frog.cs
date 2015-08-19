namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Frog : Animal, ISound
    {
        public Frog(string name, int age, Gender sex) : base(name, age, sex)
        {
        }

        public override void MakeSound()
        {
            string sound = "Bylbuk";
        }
    }
}
