namespace Cooking
{
    using System;
    using System.Collections.Generic;

    public class Bowl
    {
        private List<Vegetable> collectionOfProducts;

        public Bowl() 
        {
            this.collectionOfProducts = new List<Vegetable>();
        }

        public void Add(Vegetable product)
        {
            this.collectionOfProducts.Add(product);
        }
    }
}
