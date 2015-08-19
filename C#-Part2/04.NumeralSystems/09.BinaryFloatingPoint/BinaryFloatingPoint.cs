using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BinaryFloatingPoint
{
    public static void Main()
    {
        float number = float.Parse(Console.ReadLine());
        string numberToString = number.ToString();
        string[] arrayParts = numberToString.Split('.');
        string leftPartBinary = ConverterLeftPart(arrayParts[0]);
        string rightPartBinary = ConverterRightPart(arrayParts[1]);
        StringBuilder sb = new StringBuilder();
        sb.Append(leftPartBinary.Substring(1, leftPartBinary.Length - 1));
        sb.Append(rightPartBinary);
        int shift = leftPartBinary.Length - 1;
        int leftPartBias = 127 + shift;
        string leftPartBiasStr = leftPartBias.ToString();
        leftPartBinary = ConverterLeftPart(leftPartBiasStr);
        if (sb.Length < 23)
        {
            for (int i = sb.Length; i < 23; i++)
            {
                sb.Append('0');
            }
        }

        StringBuilder allParts = new StringBuilder();
        if (number < 0)
        {
            allParts.Append('1');
        }
        else
        {
            allParts.Append('0');
        }

        allParts.Append(leftPartBinary);
        if (sb.Length > 23)
        {
            sb.Remove(23, sb.Length - 23);
        }

        allParts.Append(sb);
        Console.WriteLine(allParts.ToString());
    }

    public static string ConverterLeftPart(string numberToString)
    {
        int leftPartDecimal = int.Parse(numberToString);
        leftPartDecimal = Math.Abs(leftPartDecimal);
        string leftPartBinary = string.Empty;
        while (leftPartDecimal > 0)
        {
            int digit = leftPartDecimal % 2;
            leftPartDecimal /= 2;
            leftPartBinary = digit + leftPartBinary;
        }

        return leftPartBinary;
    }

    public static string ConverterRightPart(string numberToString)
    {
        double rightPartDecimal = double.Parse(numberToString);
        rightPartDecimal = rightPartDecimal / Math.Pow(10, numberToString.Length);
        string rightPartBinary = string.Empty;
        while (rightPartDecimal != 0 && rightPartBinary.Length < 23)
        {
            rightPartDecimal = rightPartDecimal * 2;
            if (rightPartDecimal < 1)
            {
                rightPartBinary = rightPartBinary + '0';
                continue;
            }
            else if (rightPartDecimal == 1)
            {
                rightPartBinary = rightPartBinary + '1';
                rightPartDecimal = 0;
            }
            else if (rightPartDecimal > 1)
            {
                rightPartBinary = rightPartBinary + '1';
                rightPartDecimal = rightPartDecimal - 1;
            }
        }

        return rightPartBinary;
    }
}