using System;

namespace Recursion
{
    /// <summary>
    /// Modify the above program to check whether a path exists between two cells without finding all possible paths.
    /// Test it over an empty 100 x 100 matrix.
    /// </summary>
    public class FindExistingPath
    {
        private static string[,] matrix;
        private static int endX;
        private static int endY;
        private static bool isFound;

        public static void Main()
        {
            matrix= new string[100, 100];
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    matrix[i, j] = " ";
                }
            }

            isFound = false;
            endX = 19;
            endY = 19;
            Move(0, 0);
        }

        private static void Move(int currentX, int currentY)
        {          

            if ((matrix[currentX, currentY] == "p")
                || (matrix[currentX, currentY] == "x")
                || (currentX >= matrix.GetLength(0))
                || (currentX < 0)
                || (currentY >= matrix.GetLength(1))
                || (currentY < 0))
            {
                return;
            }

            if (currentX == endX && currentY == endY)
            {                
                Console.WriteLine("PathFound");
                Environment.Exit(0);
            }
            if (matrix[currentX, currentY] == "p")
            {
                return;
            }

            matrix[currentX, currentY] = "p";
            if (currentX > 0 && matrix[currentX - 1, currentY] == " ")
            {
                Move(currentX - 1, currentY);
            }
            if (currentX < matrix.GetLength(0) - 1 && matrix[currentX + 1, currentY] == " ")
            {
                Move(currentX + 1, currentY);
            }
            if (currentY > 0 && matrix[currentX, currentY - 1] == " ")
            {
                Move(currentX, currentY - 1);
            }
            if (currentY < matrix.GetLength(1) - 1 && matrix[currentX, currentY + 1] == " ")
            {
                Move(currentX, currentY + 1);
            }
            // matrix[currentX, currentY] = " ";
        }
    }
}