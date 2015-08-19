namespace CompareAdvancedMaths
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TestSqrt
    {
        public static void TestSqrtFloat()
        {           
            Console.WriteLine("Test Sqrt/Float");
            for (int i = 0; i < 10; i++)
            {
                float testFloat = 10f;
                double result = 0f;
                Stopwatch sw = Stopwatch.StartNew();
                for (int j = 0; j < 1000; j++)
                {
                    result = Math.Sqrt(testFloat);
                }

                sw.Stop();             
                Console.WriteLine(sw.Elapsed);
            }
        }

        public static void TestSqrtDouble()
        {
            Console.SetCursorPosition(20, 0);
            Console.WriteLine("Test Sqrt/Double");
            for (int i = 0; i < 10; i++)
            {
                double testDouble = 10d;
                double result = 0;
                Stopwatch sw = Stopwatch.StartNew();
                for (int j = 0; j < 1000; j++)
                {
                    result = Math.Sqrt(testDouble);
                }

                sw.Stop();
                Console.SetCursorPosition(20, 1 + i);
                Console.WriteLine(sw.Elapsed);
            }
        }

        public static void TestSqrtDecimal()
        {
            Console.SetCursorPosition(40, 0);
            Console.WriteLine("Test Sqrt/Decimal");
            for (int i = 0; i < 10; i++)
            {
                decimal testDecimal = 10m;
                double result = 0;
                Stopwatch sw = Stopwatch.StartNew();
                for (int j = 0; j < 1000; j++)
                {
                    result = Math.Sqrt(Convert.ToDouble(testDecimal));
                }

                sw.Stop();
                Console.SetCursorPosition(40, 1 + i);
                Console.WriteLine(sw.Elapsed);
            }
        }
    }
}
