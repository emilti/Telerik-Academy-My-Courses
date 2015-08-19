namespace RefactorExam1
{
    using System;   

    public class Task02
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string inputToLower = input.ToLower();
            char[] arrayOfChars = inputToLower.ToCharArray();
            long result = 0;
            for (int i = 0; i < arrayOfChars.Length; i++)
            {
                bool isGreaterThan0 = arrayOfChars[i] - 48 >= 0;
                bool isSmallerThan9 = arrayOfChars[i] - 48 <= 9;
                bool isGreaterOrEqualToA = arrayOfChars[i] - 97 >= 0;
                bool isSmallerOrEqualToZ = arrayOfChars[i] - 97 <= 25;
                if (isGreaterThan0 && isSmallerThan9)
                {
                    result = result * (arrayOfChars[i] - 48);
                }
                else if (isGreaterOrEqualToA && isSmallerOrEqualToZ)
                {
                    result = result + (arrayOfChars[i] - 97);
                }
                else if (arrayOfChars[i] == '@')
                {
                    break;
                }
                else
                {
                    result = result % number;
                }
            }

            Console.WriteLine(result);
        }
    }
}