namespace CreationalPatterns
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MeatballsCooker : Cooker
    {
        public MeatballsCooker()
        {
             this.Dish = new Dish("Meatballs");
        }
      
        public override void PrepareProducts()
        {
            this.Dish.Preparing = "Milling";
        }

        public override void Cook()
        {
            this.Dish.Cooking = "Frying";
        }

        public override void GetLengthOfCooking()
        {
            this.Dish.Length = 30;
        }
    }
}
