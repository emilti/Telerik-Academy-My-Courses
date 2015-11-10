using System;

namespace Recursion
{
    /// <summary>
    /// 07.We are given a matrix of passable and non-passable cells.
    /// Write a recursive program for finding all paths between two cells in the matrix.
    /// </summary>
    public class FindAllPathsInMatrix
    {
        private static string[,] matrix;     
        private static int endX;
        private static int endY;

        public static void Main()
        {            
            matrix = new string[4, 4]
            {{" ","x"," ", " " },
             {" "," "," ", " "},
             {" "," "," ", "x"} ,
             {" "," "," ", "x"} };
           
            endX = 1;
            endY = 1;
            Move(0, 0);
        }

        private static void Move(int currentX, int currentY)
        {
            if((matrix[currentX, currentY]  == "p")
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
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("end");
                return;
            }
            matrix[currentX, currentY] = "p";
            if(currentX > 0 && matrix[currentX -1, currentY] == " ")
            {
                Move(currentX - 1, currentY);
            }
            if (currentX < matrix.GetLength(0) - 1 && matrix[currentX + 1, currentY] == " ")
            {
                Move(currentX + 1, currentY);
            }
            if(currentY > 0 && matrix[currentX, currentY - 1] == " ")
            {
                Move(currentX, currentY - 1);
            }
            if(currentY < matrix.GetLength(1) - 1 && matrix[currentX, currentY + 1] == " ")
            {
                Move(currentX, currentY + 1);
            }
            matrix[currentX, currentY] = " ";
        }
    }
}