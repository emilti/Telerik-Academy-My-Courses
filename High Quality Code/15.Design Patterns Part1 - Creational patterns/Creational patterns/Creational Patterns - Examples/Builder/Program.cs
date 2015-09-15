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
            // We can choose concrete constructor (director)
            var constructor = new DishConstructor();

            // And we can choose concrete builder
            var potatoCooker = new FriedPotatoesCooker();
            constructor.Construct(potatoCooker);

            var meatCooker = new MeatballsCooker();
            constructor.Construct(meatCooker);   
        }
    }
}
