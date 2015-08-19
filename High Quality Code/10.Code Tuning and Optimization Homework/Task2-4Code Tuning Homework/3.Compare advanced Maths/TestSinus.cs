namespace CompareAdvancedMaths
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TestSinus
    {
        public static void TestSinusFloat()
        {
            Console.WriteLine();
            Console.WriteLine("Test Sinus/Float");
            for (int i = 0; i < 10; i++)
            {
                float testFloat = 10f;
                double result = 0f;
                Stopwatch sw = Stopwatch.StartNew();
                for (int j = 0; j < 1000; j++)
                {
                    result = Math.Sin(testFloat);
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }

        public static void TestSinusDouble()
        {
            Console.SetCursorPosition(20, 24);
            Console.WriteLine("Test Sinus/Double");
            for (int i = 0; i < 10; i++)
            {
                double testDouble = 10d;
                double result = 0;
                Stopwatch sw = Stopwatch.StartNew();
                for (int j = 0; j < 1000; j++)
                {
                    result = Math.Sin(testDouble);
                }

                sw.Stop();
                Console.SetCursorPosition(20, 25 + i);
                Console.WriteLine(sw.Elapsed);
            }
        }

        public static void TestSinusDecimal()
        {
            Console.SetCursorPosition(40, 24);
            Console.WriteLine("Test Sinus/Decimal");
            for (int i = 0; i < 10; i++)
            {
                decimal testDecimal = 10m;
                double result = 0;
                Stopwatch sw = Stopwatch.StartNew();
                for (int j = 0; j < 1000; j++)
                {
                    result = Math.Sin(Convert.ToDouble(testDecimal));
                }

                sw.Stop();
                Console.SetCursorPosition(40, 25 + i);
                Console.WriteLine(sw.Elapsed);
            }
        }
    }
}
