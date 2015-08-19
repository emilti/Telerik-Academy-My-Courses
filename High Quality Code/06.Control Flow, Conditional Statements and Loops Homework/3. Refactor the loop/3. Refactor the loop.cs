namespace RefactorLoop
{
    using System;

    public class Calculation
    {
        public static void Main()
        {
            int[] array = new int[1000];
            int expectedValue = 10;            
            bool valueIsFound = false;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(array[i]);
                if (i % 10 == 0 && array[i] == expectedValue)
                {
                    valueIsFound = true;
                    break;
                }
            }

            // More code here
            if (valueIsFound)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
