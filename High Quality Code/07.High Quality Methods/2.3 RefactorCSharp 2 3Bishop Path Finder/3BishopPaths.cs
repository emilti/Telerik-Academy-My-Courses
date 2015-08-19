namespace RefactorCsharp2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            string inputRow = Console.ReadLine();
            int[] dimensionsArray = inputRow.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimensionsArray[0];
            int cols = dimensionsArray[1];
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> inputCommands = new List<string>();
            List<string> directions = new List<string>();
            List<int> lengthOfMoving = new List<int>();
            int currentRow = rows - 1;
            int currentCol = 0;
            int row = currentRow;
            int col = currentCol;
            int sum = 0;
            AddCommands(numberOfCommands, inputCommands, directions, lengthOfMoving);
            int[,] matrixWithValues = new int[rows, cols];
            CreateMatrixWithValues(rows, cols, matrixWithValues);
            for (int counter = 0; counter < numberOfCommands; counter++)
            {               
                int currentMovingLength = 1;
                while (lengthOfMoving[counter] > currentMovingLength)
                {
                    if (directions[counter] == "RU" || directions[counter] == "UR")
                    {
                        currentRow = row - 1;
                        currentCol = col + 1;
                    }
                    else if (directions[counter] == "LU" || directions[counter] == "UL")
                    {
                        currentRow = row - 1;
                        currentCol = col - 1;
                    }
                    else if (directions[counter] == "LD" || directions[counter] == "DL")
                    {
                        currentRow = row + 1;
                        currentCol = col - 1;
                    }
                    else if (directions[counter] == "RD" || directions[counter] == "DR")
                    {
                        currentRow = row + 1;
                        currentCol = col + 1;
                    }

                    if (currentCol < 0 || currentCol > cols - 1 || currentRow < 0 || currentRow > rows - 1)
                    {                      
                        currentCol = col;
                        currentRow = row;
                        break;
                    }

                    currentMovingLength += 1;
                    sum = matrixWithValues[currentRow, currentCol] + sum;
                    matrixWithValues[currentRow, currentCol] = 0;
                    col = currentCol;
                    row = currentRow;
                }
            }

            Console.WriteLine(sum);
        }

        private static void CreateMatrixWithValues(int rows, int cols, int[,] matrixWithValues)
        {
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < cols; y++)
                {
                    matrixWithValues[x, y] = ((rows - x - 1) * 3) + (y * 3);
                }
            }
        }

        private static void AddCommands(int numberOfCommands, List<string> inputCommands, List<string> directions, List<int> lengthOfMoving)
        {
            string[] splittedCommand = new string[2];
            for (int command = 0; command < numberOfCommands; command++)
            {
                inputCommands.Add(Console.ReadLine());
                splittedCommand = inputCommands[command].Split(' ');
                directions.Add(splittedCommand[0]);
                lengthOfMoving.Add(int.Parse(splittedCommand[1]));
            }
        }
    }
}
