using System;
using System.Collections.Generic;

public class FrequentNumber
{
    public static void Main()
    {
        // For check you can comment the 2 rows below and uncomment the row which have //* above them
        int[] arrayOfNumbers = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };    
    
        // int[] arrayOfNumbers = { 4, 1, 1, 1, 1, 1, 1, 1, 1, 2, 4, 9, 3 };
        // int[] arrayOfNumbers = { 4, 1, 1, 1, 1, 1, -33, -33, -33, -33, -33, -33, -33 };
        int len = 13;
 
        // Console.WriteLine("Enter the length of the array");
        // int len = int.Parse(Console.ReadLine());        
        // int[] arrayOfNumbers = new int[len];
        List<int> listOfValues = new List<int>();
        int countOfEqualNumbers = 0;
        int maxCountOfEqualNumbers = 0;
        for (int index = 0; index < len; index++)
        {    
            // arrayOfNumbers[index] = int.Parse(Console.ReadLine());
            if (index == 0 || (index > 0 && arrayOfNumbers[index] != arrayOfNumbers[index - 1]))
            {
                listOfValues.Add(arrayOfNumbers[index]);
            }
        }

        int indexOfMax = 0;
        for (int i = 0; i < listOfValues.Count; i++)
        {
            for (int j = 0; j < arrayOfNumbers.Length; j++)
            {
                if (listOfValues[i] == arrayOfNumbers[j])
                {
                    countOfEqualNumbers++;
                }
            }

            if (countOfEqualNumbers > maxCountOfEqualNumbers)
            {
                maxCountOfEqualNumbers = countOfEqualNumbers;
                countOfEqualNumbers = 0;
                indexOfMax = i;
            }
            else
            {
                countOfEqualNumbers = 0;
            }
        }

        Console.WriteLine("{0} ({1} times)", listOfValues[indexOfMax], maxCountOfEqualNumbers);
    }
}