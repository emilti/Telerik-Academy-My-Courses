namespace LinearDataStructures
{
    using System;
    using System.Collections.Generic;

   /// <summary>
   ///  03.Write a program that reads a sequence of integers (List<int>) ending with an empty line
   /// and sorts them in an increasing order.
   /// </summary>   
    public class SortSequenceInIncreasingOrder
    {
        public static void Main()
        {           
            List<int> numbers = new List<int>();

            numbers = new List<int> { 2, 3, -2, -1, -1 };
            
            // EnterNumbers(numbers);
            SelectSort(numbers);

            Console.WriteLine("Sorted Numbers:");
            Console.WriteLine(string.Join(", ", numbers));
        }

        private static void EnterNumbers(List<int> numbers)
        {
            Console.WriteLine("Enter numbers:");
            while (true)
            {
                string input = Console.ReadLine();
                if (input != string.Empty)
                {
                    int parsedInput = int.Parse(input);
                    numbers.Add(parsedInput);
                }
                else
                {
                    break;
                }
            }
        }
        
        private static void SelectSort(List<int> numbers)
        {
            // pos_min is short for position of min
            int pos_min, temp;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                pos_min = i;

                // set pos_min to the current index of array
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[j] < numbers[pos_min])
                    {
                        // pos_min will keep track of the index that min is in, this is needed when a swap happens
                        pos_min = j;
                    }
                }

                // if pos_min no longer equals i than a smaller value must have been found, so a swap must occur
                if (pos_min != i)
                {
                    temp = numbers[i];
                    numbers[i] = numbers[pos_min];
                    numbers[pos_min] = temp;
                }
            }
        }
    }
}
