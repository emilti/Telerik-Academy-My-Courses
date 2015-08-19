namespace RefactorExam1
{
    using System;

    public class Task05
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string wholeSequence = ConvertLongToBinary(number);
            int longestZeroSeq;
            int longestOneSeq;
            CountBits(wholeSequence, out longestZeroSeq, out longestOneSeq);
            Console.WriteLine("{0}", longestZeroSeq);
            Console.WriteLine("{0}", longestOneSeq);
        }

        private static string ConvertLongToBinary(int number)
        {
            string wholeSequence = string.Empty;
            for (int i = 0; i < number; i++)
            {
                long numberForTheSequence = long.Parse(Console.ReadLine());
                string binaryNumber = Convert.ToString(numberForTheSequence, 2).PadLeft(30, '0');
                wholeSequence = wholeSequence + binaryNumber;
            }

            return wholeSequence;
        }

        private static void CountBits(string all, out int longestZeroSeq, out int longestOneSeq)
        {
            char[] arrayOfChars = all.ToCharArray();
            int zeroCheck = 0;
            int onesCheck = 0;
            longestZeroSeq = 0;
            longestOneSeq = 0;
            for (int i = 0; i < arrayOfChars.Length; i++)
            {
                if (arrayOfChars[i] == '0')
                {
                    zeroCheck++;
                }
                else
                {
                    onesCheck++;
                }

                if (zeroCheck > longestZeroSeq)
                {
                    longestZeroSeq = zeroCheck;
                }

                if (onesCheck > longestOneSeq)
                {
                    longestOneSeq = onesCheck;
                }

                if (arrayOfChars[i] == '1' && i > 0 && arrayOfChars[i - 1] == '0')
                {
                    zeroCheck = 0;
                }

                if (arrayOfChars[i] == '0' && i > 0 && arrayOfChars[i - 1] == '1')
                {
                    onesCheck = 0;
                }
            }
        }
    }
}
