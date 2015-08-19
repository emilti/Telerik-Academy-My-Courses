namespace CompareAdvancedMaths
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TestLog
    {
        public static void TestLogFloat()
        {
            Console.WriteLine();
            Console.WriteLine("Test Log/Float");
            for (int i = 0; i < 10; i++)
            {
                float testFloat = 10f;
                double result = 0f;
                Stopwatch sw = Stopwatch.StartNew();
                for (int j = 0; j < 1000; j++)
                {
                    result = Math.Log(testFloat);
                }

                sw.Stop();                
                Console.WriteLine(sw.Elapsed);
            }
        }

        public static void TestLogDouble()
        {
            Console.SetCursorPosition(20, 12);
            Console.WriteLine("Test Log/Double");
            for (int i = 0; i < 10; i++)
            {
                double testDouble = 10d;
                double result = 0;
                Stopwatch sw = Stopwatch.StartNew();
                for (int j = 0; j < 1000; j++)
                {
                    result = Math.Log(testDouble);
                }

                sw.Stop();
                Console.SetCursorPosition(20, 13 + i);
                Console.WriteLine(sw.Elapsed);
            }
        }

        public static void TestLogDecimal()
        {
            Console.SetCursorPosition(40, 12);
            Console.WriteLine("Test Log/Decimal");
            for (int i = 0; i < 10; i++)
            {
                decimal testDecimal = 10m;
                double result = 0;
                Stopwatch sw = Stopwatch.StartNew();
                for (int j = 0; j < 1000; j++)
                {
                    result = Math.Log(Convert.ToDouble(testDecimal));
                }

                sw.Stop();
                Console.SetCursorPosition(40, 13 + i);
                Console.WriteLine(sw.Elapsed);
            }
        }
    }
}
