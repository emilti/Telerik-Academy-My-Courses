using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SeqnMatrix
{
    public static void Main()
    {
        // Console.WriteLine("N and M sides of the m,atrix:");
        // int numberN=int.Parse(Console.ReadLine());
        // int numberM=int.Parse(Console.ReadLine());
        // Console.WriteLine("Enter the matrix:");
        int numberN = 3;
        int numberM = 4;

        // string[,] matrix = new string[3,4]
        // {
        //     {"ha","fifi","ho","hi"},
        //     {"fo","ha","hi","xx"},
        //     {"xxx","ho","ha","xx"}           
        // };
        string[,] matrix = new string[3, 4]
        {
            { "z", "a", "c", "a" },
            { "c", "c", "c", "c" },
            { "c", "ho", "ha", "xx" }           
        };

        // string[,] matrix = new string[3,3]
        // {
        // {"s", "qq","s"},
        // {"pp", "pp","s"},
        // {"pp", "qq","s"},
        // };
        int smallest = numberN > numberM ? numberM : numberN;

        // string[,] matrix=new string[numberN,numberM];
        // for (int i = 0; i < numberN; i++)
        // {
        //     for (int j = 0; j < numberM; j++)
        //     {
        //         matrix[i.j] = Console.ReadLine();
        //     }
        // }
        int countOfEqualElements = 0;
        int currentRightDiagonalElements = 0;
        int currentLeftDiagonalElements = 0;
        int currentHorizontalElements = 0;
        int currentVerticalElements = 0;
        string currentChecked = string.Empty;        
        string finalEqual = string.Empty;
        for (int i = 0; i < numberN; i++)
        {
            for (int j = 0; j < numberM; j++)
            {
                for (int offset = 0; offset < smallest; offset++)
                {
                    if (offset + j >= numberM || offset + i >= numberN)
                    {
                        break;
                    }

                    if (matrix[i, j].Equals(matrix[i + offset, j + offset]))
                    {
                        currentLeftDiagonalElements++;
                        currentChecked = matrix[i, j];
                    }
                    else
                    {
                        break;
                    }
                }

                for (int offset = 0; offset < smallest; offset++)
                {
                    if (j - offset < 0 || offset + i >= numberN)
                    {
                        break;
                    }

                    if (matrix[i, j].Equals(matrix[i + offset, j - offset]))
                    {
                        currentRightDiagonalElements++;
                        currentChecked = matrix[i, j];
                    }
                    else
                    {
                        break;
                    }
                }

                for (int offset = 0; offset < numberN; offset++)
                {
                    if (offset + i >= numberN)
                    {
                        break;
                    }

                    if (matrix[i, j].Equals(matrix[i + offset, j]))
                    {
                        currentVerticalElements++;
                        currentChecked = matrix[i, j];
                    }
                    else
                    {
                        break;
                    }
                }

                for (int offset = 0; offset < numberM; offset++)
                {
                    if (offset + j >= numberM)
                    {
                        break;
                    }

                    if (matrix[i, j].Equals(matrix[i, j + offset]))
                    {
                        currentHorizontalElements++;
                        currentChecked = matrix[i, j];
                    }
                    else
                    {
                        break;
                    }
                }

                int[] arrayOfElements = { currentLeftDiagonalElements, currentRightDiagonalElements, currentHorizontalElements, currentVerticalElements };
                Array.Sort(arrayOfElements);                
                if (arrayOfElements[3] > countOfEqualElements)
                {
                    countOfEqualElements = arrayOfElements[3];                   
                    finalEqual = currentChecked;
                }

                currentRightDiagonalElements = 0;
                currentLeftDiagonalElements = 0;
                currentHorizontalElements = 0;
                currentVerticalElements = 0;                
            }
        } 
      
        for (int i = 0; i < countOfEqualElements; i++)
        {
            Console.Write("{0}", finalEqual);
            if (i < countOfEqualElements - 1)
            {
                Console.Write(", ");
            }           
        }

        Console.WriteLine();
    }
}