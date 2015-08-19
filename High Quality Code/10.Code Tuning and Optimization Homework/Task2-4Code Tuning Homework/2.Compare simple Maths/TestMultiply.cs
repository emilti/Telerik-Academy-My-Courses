namespace CompareSimpleMaths
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TestMultiply
    {
        public static void TestMultiplyInt()
        {
            Console.WriteLine();
            Console.WriteLine("Test Multiply/Int");
            for (int i = 0; i < 10; i++)
            {
                int testInt = 10;
                int result = 0;
                Stopwatch sw = Stopwatch.StartNew();
                for (int j = 0; j < 1000; j++)
                {
                    result = testInt * 1;
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }

        public static void TestMultiplyLong()
        {
            Console.SetCursorPosition(20, 36);
            Console.WriteLine("Test Multiply/Long");
            for (int i = 0; i < 10; i++)
            {
                long testLong = 10;
                long result = 0;
                Stopwatch sw = Stopwatch.StartNew();
                for (int j = 0; j < 1000; j++)
                {
                    result = testLong * 1;
                }

                sw.Stop();
                Console.SetCursorPosition(20, 37 + i);
                Console.WriteLine(sw.Elapsed);
            }
        }

        public static void TestMultiplyFloat()
        {
            Console.SetCursorPosition(40, 36);
            Console.WriteLine("Test Multiply/Float");
            for (int i = 0; i < 10; i++)
            {
                float testFloat = 10f;
                float result = 0f;
                Stopwatch sw = Stopwatch.StartNew();
                for (int j = 0; j < 1000; j++)
                {
                    result = testFloat * 1;
                }

                sw.Stop();
                Console.SetCursorPosition(40, 37 + i);
                Console.WriteLine(sw.Elapsed);
            }
        }

        public static void TestMultiplyDouble()
        {
            Console.SetCursorPosition(60, 36);
            Console.WriteLine("Test Multiply/Double");
            for (int i = 0; i < 10; i++)
            {
                double testDouble = 10d;
                double result = 0;
                Stopwatch sw = Stopwatch.StartNew();
                for (int j = 0; j < 1000; j++)
                {
                    result = testDouble * 1;
                }

                sw.Stop();
                Console.SetCursorPosition(60, 37 + i);
                Console.WriteLine(sw.Elapsed);
            }
        }

        public static void TestMultiplyDecimal()
        {
            Console.SetCursorPosition(80, 36);
            Console.WriteLine("Test Multiply/Decimal");
            for (int i = 0; i < 10; i++)
            {
                decimal testDecimal = 10m;
                decimal result = 0m;
                Stopwatch sw = Stopwatch.StartNew();
                for (int j = 0; j < 1000; j++)
                {
                    result = testDecimal * 1;
                }

                sw.Stop();
                Console.SetCursorPosition(80, 37 + i);
                Console.WriteLine(sw.Elapsed);
            }
        }
    }
}
