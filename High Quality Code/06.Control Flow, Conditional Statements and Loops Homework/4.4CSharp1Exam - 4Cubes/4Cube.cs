namespace RefactorExam1
{
    using System;

    public class Task04
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string topRowColon = new string(':', number);
            string topRowSpace = new string(' ', number - 1);
            Console.WriteLine("{0}{1}", topRowSpace, topRowColon);
            DrawTop(number);

            string middleRowCube = new string(':', number);
            string middleRowSideCube = new string('X', number - 2);
            Console.WriteLine("{0}{1}:", middleRowCube, middleRowSideCube);
            DrawBottom(number);
        }

        private static void DrawBottom(int number)
        {
            for (int j = 0; j < number - 2; j++)
            {
                string frontCube = new string(' ', number - 2);
                string bottomSideCube = new string('X', number - 3 - j);
                Console.WriteLine(":{0}:{1}:", frontCube, bottomSideCube);
            }

            string bottomRow = new string(':', number);
            Console.WriteLine("{0}", bottomRow);
        }

        private static void DrawTop(int number)
        {
            for (int i = 0; i < number - 2; i++)
            {
                string topSideSpace = new string(' ', number - i - 2);
                string topCube = new string('/', number - 2);
                string sideCube = new string('X', i);
                if (i == 0)
                {
                    Console.WriteLine("{0}:{1}::", topSideSpace, topCube);
                }
                else if (i >= 1)
                {
                    Console.WriteLine("{0}:{1}:{2}:", topSideSpace, topCube, sideCube);
                }
            }
        }
    }
}
