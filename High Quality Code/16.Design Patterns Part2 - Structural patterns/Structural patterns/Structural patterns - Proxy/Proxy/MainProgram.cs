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
            Image image = new ProxyImage("test_10mb.jpg");

            //image will be loaded from disk
            image.display();
            Console.WriteLine("");

            //image will not be loaded from disk
            image.display();
        }
    }
} 