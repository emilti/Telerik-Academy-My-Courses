namespace CompareSimpleMaths
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TestSubtract
    {
        public static void TestSubtractInt()
        {
            Console.WriteLine();
            Console.WriteLine("Test Subtract/Int");
            for (int i = 0; i < 10; i++)
            {
                int testInt = 10;
                int result = 0;
                Stopwatch sw = Stopwatch.StartNew();
                for (int j = 0; j < 1000; j++)
                {
                    result = testInt - 10;
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }

        public static void TestSubtractLong()
        {
            Console.SetCursorPosition(20, 12);
            Console.WriteLine("Test Subtract/Long");
            for (int i = 0; i < 10; i++)
            {
                long testLong = 10;
                long result = 0;
                Stopwatch sw = Stopwatch.StartNew();
                for (int j = 0; j < 1000; j++)
                {
                    result = testLong - 10;
                }

                sw.Stop();
                Console.SetCursorPosition(20, 13 + i);
                Console.WriteLine(sw.Elapsed);
            }
        }

        public static void TestSubtractFloat()
        {
            Console.SetCursorPosition(40, 12);
            Console.WriteLine("Test Subtract/Float");
            for (int i = 0; i < 10; i++)
            {
                float testFloat = 10f;
                float result = 0f;
                Stopwatch sw = Stopwatch.StartNew();
                for (int j = 0; j < 1000; j++)
                {
                    result = testFloat - 10;
                }

                sw.Stop();
                Console.SetCursorPosition(40, 13 + i);
                Console.WriteLine(sw.Elapsed);
            }
        }

        public static void TestSubtractDouble()
        {
            Console.SetCursorPosition(60, 12);
            Console.WriteLine("Test Subtract/Double");
            for (int i = 0; i < 10; i++)
            {
                double testDouble = 10d;
                double result = 0;
                Stopwatch sw = Stopwatch.StartNew();
                for (int j = 0; j < 1000; j++)
                {
                    result = testDouble - 10;
                }

                sw.Stop();
                Console.SetCursorPosition(60, 13 + i);
                Console.WriteLine(sw.Elapsed);
            }
        }

        public static void TestSubtractDecimal()
        {
            Console.SetCursorPosition(80, 12);
            Console.WriteLine("Test Subtract/Decimal");
            for (int i = 0; i < 10; i++)
            {
                decimal testDecimal = 10m;
                decimal result = 0m;
                Stopwatch sw = Stopwatch.StartNew();
                for (int j = 0; j < 1000; j++)
                {
                    result = testDecimal - 10;
                }

                sw.Stop();
                Console.SetCursorPosition(80, 13 + i);
                Console.WriteLine(sw.Elapsed);
            }
        }
    }
}
