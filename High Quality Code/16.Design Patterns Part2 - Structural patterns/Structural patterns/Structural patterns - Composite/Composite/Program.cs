namespace StructuralPatterns
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MainProgram
    {
        public static void Main()
        {
            var bigBoss = new ChiefExecutive("Big Boss");
            var smallBoss = new ChiefExecutive("Small Boss");
            bigBoss.Add(smallBoss);
            smallBoss.Add(new RegularEmployee("Pesho"));
            smallBoss.Add(new RegularEmployee("Ivan"));
            bigBoss.Display(1);
        }
    }
}
