namespace CompareSimpleMaths
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TestAdd
    {
        public static void TestAddInt()
        {
            Console.WriteLine("Test Add/Int");
            for (int i = 0; i < 10; i++)
            {
                int testInt = 10;
                int result = 0;
                Stopwatch sw = Stopwatch.StartNew();
                for (int j = 0; j < 1000; j++)
                {
                    result = testInt + 10;
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }

        public static void TestAddLong()
        {
            Console.SetCursorPosition(20, 0);
            Console.WriteLine("Test Add/Long");
            for (int i = 0; i < 10; i++)
            {
                long testLong = 10;
                long result = 0;
                Stopwatch sw = Stopwatch.StartNew();
                for (int j = 0; j < 1000; j++)
                {
                    result = testLong + 10;
                }

                sw.Stop();
                Console.SetCursorPosition(20, 1 + i);
                Console.WriteLine(sw.Elapsed);
            }
        }

        public static void TestAddFloat()
        {
            Console.SetCursorPosition(40, 0);
            Console.WriteLine("Test Add/Float");
            for (int i = 0; i < 10; i++)
            {
                float testFloat = 10f;
                float result = 0f;
                Stopwatch sw = Stopwatch.StartNew();
                for (int j = 0; j < 1000; j++)
                {
                    result = testFloat + 10;
                }

                sw.Stop();
                Console.SetCursorPosition(40, 1 + i);
                Console.WriteLine(sw.Elapsed);
            }
        }

        public static void TestAddDouble()
        {
            Console.SetCursorPosition(60, 0);
            Console.WriteLine("Test Add/Double");
            for (int i = 0; i < 10; i++)
            {
                double testDouble = 10d;
                double result = 0;
                Stopwatch sw = Stopwatch.StartNew();
                for (int j = 0; j < 1000; j++)
                {
                    result = testDouble + 10;
                }

                sw.Stop();
                Console.SetCursorPosition(60, 1 + i);
                Console.WriteLine(sw.Elapsed);
            }
        }

        public static void TestAddDecimal()
        {
            Console.SetCursorPosition(80, 0);
            Console.WriteLine("Test Add/Decimal");
            for (int i = 0; i < 10; i++)
            {
                decimal testDecimal = 10m;
                decimal result = 0m;
                Stopwatch sw = Stopwatch.StartNew();
                for (int j = 0; j < 1000; j++)
                {
                    result = testDecimal + 10;
                }

                sw.Stop();
                Console.SetCursorPosition(80, 1 + i);
                Console.WriteLine(sw.Elapsed);
            }        
        }
    }
}
