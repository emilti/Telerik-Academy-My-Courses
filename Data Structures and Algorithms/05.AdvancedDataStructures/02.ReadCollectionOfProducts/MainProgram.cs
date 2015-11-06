using System;
using System.Linq;
using Wintellect.PowerCollections;

namespace AdvancedDataStructures
{
    /// <summary>
    /// Write a program to read a large collection of products (name + price) 
    /// and efficiently find the first 20 products in the price range [a…b].
    /// Test for 500 000 products and 10 000 price searches.
    /// Hint: you may use OrderedBag<T> and sub-ranges.
    /// </summary>
    public class Program
    {
        public static void Main()
        {            
            OrderedBag<Product> products = new OrderedBag<Product>();
            Random random = new Random();
            for (int i =0; i < 500000; i++)
            {
                Product product = new Product(i.ToString(), random.Next(0, 500000));
                products.Add(product);            }

            for (int i = 0; i < 10000; i++)
            {
                Product bottomBoundProduct = new Product(string.Empty,random.Next(0, 499950));
                Product topBoundProduct = new Product(string.Empty, bottomBoundProduct.Price + 50);
                var result = products.Range(bottomBoundProduct, true, topBoundProduct,true).Take(20).ToList();
                for (int j = 0; j < 20; j++)
                {
                    Console.WriteLine("Name:" + result[j].Name +" Price:" + result[j].Price);
                }
                Console.WriteLine("End of range");
            }

        }
    }
}
