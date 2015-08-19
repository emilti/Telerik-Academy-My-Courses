namespace RefactorCsharp2
{
    using System;

    public class Task01
    {
        public static void Main()
        {
            string numbersIn19th = Console.ReadLine();
            string[] arrayOfNumbersIn19th = numbersIn19th.Split(' ');
            double[] arayOfNumbersIn10th = new double[arrayOfNumbersIn19th.Length];
            double totalSumIn10th = 0;
            string totalsumIn19th = string.Empty;
            totalSumIn10th = ConvertNumbersFrom19thTo10th(arrayOfNumbersIn19th, arayOfNumbersIn10th, totalSumIn10th);

            double finalSumIn10thForPrinting = totalSumIn10th;
            if (totalSumIn10th == 0)
            {
                totalsumIn19th = "a";
            }

            ConvertTotalSumFrom10thTo19th(ref totalSumIn10th, ref totalsumIn19th);

            Console.WriteLine("{0} = {1}", totalsumIn19th, finalSumIn10thForPrinting);
        }

        private static void ConvertTotalSumFrom10thTo19th(ref double totalSumIn10th, ref string totalsumIn19th)
        {
            while (totalSumIn10th > 0)
            {
                double digit = totalSumIn10th % 19;
                char digitChar = (char)(digit + 97);
                totalsumIn19th = (string)((char)digitChar + totalsumIn19th + string.Empty);
                totalSumIn10th = (int)totalSumIn10th / 19;
            }
        }

        private static double ConvertNumbersFrom19thTo10th(string[] arrayOfNumbersIn19th, double[] arayOfDecimalNumbers, double totalSumInDecimal)
        {
            for (int i = 0; i < arrayOfNumbersIn19th.Length; i++)
            {
                for (int j = 0; j < arrayOfNumbersIn19th[i].Length; j++)
                {
                    arayOfDecimalNumbers[i] = ((arrayOfNumbersIn19th[i][arrayOfNumbersIn19th[i].Length - j - 1] - 97) *
                        Math.Pow(19, j)) + arayOfDecimalNumbers[i];
                }

                totalSumInDecimal += arayOfDecimalNumbers[i];
            }

            return totalSumInDecimal;
        }
    }
}