using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MatrixForUser
{
    public static void Main()
    {
        MatrixClass matrix1 = new MatrixClass(2, 2);
        matrix1[0, 0] = 1;
        matrix1[0, 1] = -2;
        matrix1[1, 0] = 3;
        matrix1[1, 1] = 3;
        MatrixClass matrix2 = new MatrixClass(2, 2);
        matrix2[0, 0] = 4;
        matrix2[0, 1] = 4;
        matrix2[1, 0] = 5;
        matrix2[1, 1] = 5;

        MatrixClass resultSum = matrix1 + matrix2;
        Console.WriteLine("Adding the two matrix:");
        Console.WriteLine(resultSum.ToString());
        MatrixClass resultExtraction = matrix1 - matrix2;
        Console.WriteLine("Extract Matrix2 from Matrix1:");
        Console.WriteLine(resultExtraction.ToString());
        MatrixClass resultMultiplication = matrix1 * matrix2;
        Console.WriteLine("Result of multiplication of Matrix1 and Matrix2:");
        Console.WriteLine(resultMultiplication.ToString());
    }  
}