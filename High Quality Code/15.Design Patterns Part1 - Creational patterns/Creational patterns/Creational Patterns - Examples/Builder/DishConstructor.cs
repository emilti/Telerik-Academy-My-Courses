namespace CreationalPatterns
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DishConstructor
    {
        public void Construct(Cooker cooker)
        {
            cooker.PrepareProducts();
            cooker.Cook();
            cooker.GetLengthOfCooking();
        }
    }
}
