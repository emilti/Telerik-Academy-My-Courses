namespace CreationalPatterns
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FriedPotatoesCooker : Cooker
    {
        public FriedPotatoesCooker()
        {
             this.Dish = new Dish("Fried Potatos");
        }

        public override void PrepareProducts()
        {
            this.Dish.Preparing = "Peel";
        }

        public override void Cook()
        {
            this.Dish.Cooking = "Frying";
        }

        public override void GetLengthOfCooking()
        {
            this.Dish.Length = 20;
        }
    }
}
