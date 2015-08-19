namespace RefactorExam1
{
    using System;    
    using System.Collections.Generic;
    using System.Numerics;

    public class Task03
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            char[] collectionOfChars = number.ToString().ToCharArray();
            bool isNumberLong = true;
            bool isReachedZero = false;
            long transformation = 0;
            int sum = 0;
            List<int> collectionOfDigitsSum = new List<int>();
            BigInteger product = 1;
            BigInteger interimProduct = 0;
            int countOfTransformedDigits = 0;
            int end = collectionOfChars.Length - 1;
            while (isNumberLong)
            {
                int last = collectionOfChars[collectionOfChars.Length - 1];
                for (int i = end; i >= 0; i--)
                {
                    collectionOfChars[i] = ' ';
                    if (isReachedZero == false)
                    {
                        sum = CalculatingSum(collectionOfChars, sum, collectionOfDigitsSum, i);                
                    }
                    else
                    {
                        product = CalculatingProduct(collectionOfDigitsSum, product);
                        transformation++;
                        collectionOfChars = product.ToString().ToCharArray();
                        interimProduct = product;
                        product = 1;
                        countOfTransformedDigits = CountTransformedDigits(collectionOfChars, countOfTransformedDigits);

                        if (countOfTransformedDigits == 1)
                        {
                            isNumberLong = false;
                            break;
                        }

                        if (transformation == 10)
                        {
                            isNumberLong = false;
                            break;
                        }

                        end = countOfTransformedDigits - 1;
                        i = end + 1;
                        countOfTransformedDigits = 0;
                        isReachedZero = false;
                    }

                    if (i == 0)
                    {
                        isReachedZero = true;
                    }
                }
            }

            if (transformation < 10)
            {
                Console.WriteLine("{0}", transformation);
                Console.WriteLine("{0}", collectionOfChars[0]);
            }
            else
            {
                Console.WriteLine("{0}", interimProduct);
            }
        }

        private static int CountTransformedDigits(char[] collectionOfChars, int countOfTransformedDigits)
        {
            for (int m = 0; m < collectionOfChars.Length; m++)
            {
                int currentNumber = collectionOfChars[m] - 48;

                if (currentNumber >= 0 && currentNumber <= 9)
                {
                    countOfTransformedDigits++;
                }
            }

            return countOfTransformedDigits;
        }

        private static BigInteger CalculatingProduct(List<int> listOfDigitsSum, BigInteger product)
        {
            for (int k = 0; k < listOfDigitsSum.Count - 1; k++)
            {
                product = product * listOfDigitsSum[k];
            }

            listOfDigitsSum.Clear();
            return product;
        }

        private static int CalculatingSum(char[] arrayOfChars, int sum, List<int> listOfDigitsSum, int i)
        {
            for (int j = 0; j < i; j++)
            {
                if (arrayOfChars[j] != ' ' && j % 2 == 0)
                {
                    sum = arrayOfChars[j] + sum - 48;
                }
            }

            listOfDigitsSum.Add(sum);
            sum = 0;
            return sum;
        }
    }
}
