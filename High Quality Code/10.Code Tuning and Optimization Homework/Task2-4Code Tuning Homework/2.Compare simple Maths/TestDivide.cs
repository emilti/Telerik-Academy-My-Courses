namespace CompareSimpleMaths
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TestDivide
    {
        public static void TestDivideInt()
        {
            Console.WriteLine();
            Console.WriteLine("Test Divide/Int");
            for (int i = 0; i < 10; i++)
            {
                int testInt = 10;
                int result = 0;
                Stopwatch sw = Stopwatch.StartNew();
                for (int j = 0; j < 1000; j++)
                {
                    result = testInt / 1;
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }

        public static void TestDivideLong()
        {
            Console.SetCursorPosition(20, 48);
            Console.WriteLine("Test Divide/Long");
            for (int i = 0; i < 10; i++)
            {
                long testLong = 10;
                long result = 0;
                Stopwatch sw = Stopwatch.StartNew();
                for (int j = 0; j < 1000; j++)
                {
                    result = testLong / 1;
                }

                sw.Stop();
                Console.SetCursorPosition(20, 49 + i);
                Console.WriteLine(sw.Elapsed);
            }
        }

        public static void TestDivideFloat()
        {
            Console.SetCursorPosition(40, 48);
            Console.WriteLine("Test Divide/Float");
            for (int i = 0; i < 10; i++)
            {
                float testFloat = 10f;
                float result = 0f;
                Stopwatch sw = Stopwatch.StartNew();
                for (int j = 0; j < 1000; j++)
                {
                    result = testFloat / 1;
                }

                sw.Stop();
                Console.SetCursorPosition(40, 49 + i);
                Console.WriteLine(sw.Elapsed);
            }
        }

        public static void TestDivideDouble()
        {
            Console.SetCursorPosition(60, 48);
            Console.WriteLine("Test Divide/Double");
            for (int i = 0; i < 10; i++)
            {
                double testDouble = 10d;
                double result = 0;
                Stopwatch sw = Stopwatch.StartNew();
                for (int j = 0; j < 1000; j++)
                {
                    result = testDouble / 1;
                }

                sw.Stop();
                Console.SetCursorPosition(60, 49 + i);
                Console.WriteLine(sw.Elapsed);
            }
        }

        public static void TestDivideDecimal()
        {
            Console.SetCursorPosition(80, 48);
            Console.WriteLine("Test Divide/Decimal");
            for (int i = 0; i < 10; i++)
            {
                decimal testDecimal = 10m;
                decimal result = 0m;
                Stopwatch sw = Stopwatch.StartNew();
                for (int j = 0; j < 1000; j++)
                {
                    result = testDecimal / 1;
                }

                sw.Stop();
                Console.SetCursorPosition(80, 49 + i);
                Console.WriteLine(sw.Elapsed);
            }
        }
    }
}
