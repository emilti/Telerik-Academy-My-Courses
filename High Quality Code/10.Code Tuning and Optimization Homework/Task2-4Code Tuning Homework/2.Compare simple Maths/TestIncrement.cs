namespace CompareSimpleMaths
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TestIncrement
    {
        public static void TestIncrementInt()
        {
            Console.WriteLine();
            Console.WriteLine("Test Increment/Int");
            for (int i = 0; i < 10; i++)
            {
                int testInt = 10;               
                Stopwatch sw = Stopwatch.StartNew();
                for (int j = 0; j < 1000; j++)
                {
                    testInt++;
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }

        public static void TestIncrementLong()
        {
            Console.SetCursorPosition(20, 24);
            Console.WriteLine("Test Increment/Long");
            for (int i = 0; i < 10; i++)
            {
                long testLong = 10;                
                Stopwatch sw = Stopwatch.StartNew();
                for (int j = 0; j < 1000; j++)
                {
                    testLong++;
                }

                sw.Stop();
                Console.SetCursorPosition(20, 25 + i);
                Console.WriteLine(sw.Elapsed);
            }
        }

        public static void TestIncrementFloat()
        {
            Console.SetCursorPosition(40, 24);
            Console.WriteLine("Test Increment/Float");
            for (int i = 0; i < 10; i++)
            {
                float testFloat = 10f;               
                Stopwatch sw = Stopwatch.StartNew();
                for (int j = 0; j < 1000; j++)
                {
                     testFloat++;
                }

                sw.Stop();
                Console.SetCursorPosition(40, 25 + i);
                Console.WriteLine(sw.Elapsed);
            }
        }

        public static void TestIncrementDouble()
        {
            Console.SetCursorPosition(60, 24);
            Console.WriteLine("Test Increment/Double");
            for (int i = 0; i < 10; i++)
            {
                double testDouble = 10d;               
                Stopwatch sw = Stopwatch.StartNew();
                for (int j = 0; j < 1000; j++)
                {
                    testDouble++;
                }

                sw.Stop();
                Console.SetCursorPosition(60, 25 + i);
                Console.WriteLine(sw.Elapsed);
            }
        }

        public static void TestIncrementDecimal()
        {
            Console.SetCursorPosition(80, 24);
            Console.WriteLine("Test Increment/Decimal");
            for (int i = 0; i < 10; i++)
            {
                decimal testDecimal = 10m;               
                Stopwatch sw = Stopwatch.StartNew();
                for (int j = 0; j < 1000; j++)
                {
                    testDecimal++;
                }

                sw.Stop();
                Console.SetCursorPosition(80, 25 + i);
                Console.WriteLine(sw.Elapsed);
            }
        }
    }
}
