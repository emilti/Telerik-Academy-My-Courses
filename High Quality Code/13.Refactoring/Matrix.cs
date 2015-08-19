namespace MatrixCreator
{
    using System;

    public class Matrix
    {
        private int[,] matrixData;
        private int size;

        public Matrix(int n)
        {
            this.Size = n;
            this.MatrixData = this.GenerateMatrix(n);
        }

        public int[,] MatrixData
        {
            get
            {
                return this.matrixData;
            }

            set
            {
                this.matrixData = value;
            }
        }

        public int Size
        {
            get 
            {
                return this.size;
            }

            set
            {               
                if (value <= 0) 
                {
                    throw new ArgumentException("Size should be positive.");
                }

                this.size = value;
            }
        }

        public bool GetDirection(int[,] arr, int x, int y, out int dx, out int dy, ref int clockWisePosition)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };
          
            for (int i = 0, movesCounter = clockWisePosition; i < 8; i++, movesCounter++)
            {
                if (movesCounter >= 8)
                {
                    movesCounter = 0;
                }

                bool xIsInMatrix = x + dirX[movesCounter] < arr.GetLength(0) && x + dirX[movesCounter] >= 0;
                bool yIsInMatrix = y + dirY[movesCounter] < arr.GetLength(0) && y + dirY[movesCounter] >= 0;
                if (xIsInMatrix && yIsInMatrix && arr[x + dirX[movesCounter], y + dirY[movesCounter]] == 0)
                {
                    clockWisePosition = movesCounter;
                    dx = dirX[movesCounter];
                    dy = dirY[movesCounter];
                    return true;
                }
            }

            dx = 0;
            dy = 0;
            return false;
        }

        public bool SearchEmptyCell(int[,] arr, out int x, out int y)
        {
            x = 0;
            y = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (arr[i, j] == 0) 
                    {
                        x = i; 
                        y = j;
                        return true; 
                    }
                }
            }

            return false;
        }

        public void WriteMatrix()
        {
            for (int p = 0; p < this.size; p++)
            {
                for (int q = 0; q < this.size; q++)
                {
                    Console.Write("{0,3}", this.matrixData[p, q]);
                }

                Console.WriteLine();
            }
        }

        private int[,] GenerateMatrix(int size)
        {
            bool isEmptyCellFound = false;            
            int[,] matrix = new int[size, size];
            int step = size, k = 1, i = 0, j = 0, dx = 1, dy = 1, clockWisePosition = 0;
            while (true)
            { 
                matrix[i, j] = k;

                if (!this.GetDirection(matrix, i, j, out dx, out dy, ref clockWisePosition))
                {
                    isEmptyCellFound = this.SearchEmptyCell(matrix, out i, out j);
                    if (isEmptyCellFound == false)
                    {
                        break;
                    }

                    clockWisePosition = 0;
                }
              
                i += dx; 
                j += dy; 
                k++;
            }

            return matrix;          
        }       
    }
}
