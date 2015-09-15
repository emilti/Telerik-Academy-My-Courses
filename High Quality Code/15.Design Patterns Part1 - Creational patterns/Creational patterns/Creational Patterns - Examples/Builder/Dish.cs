namespace CreationalPatterns
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Dish
    {
        private readonly string dish;       

        public Dish(string dish)
        {
            this.dish = dish;
        }

        public string Preparing { get; set; }

        public string Cooking { get; set; }

        public int Length { get; set; }
    }
}
