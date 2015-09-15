namespace CreationalPatterns
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Cooker
    {
        public Dish Dish { get; set; }

        public abstract void PrepareProducts();

        public abstract void Cook();

        public abstract void GetLengthOfCooking();       
    }
}
