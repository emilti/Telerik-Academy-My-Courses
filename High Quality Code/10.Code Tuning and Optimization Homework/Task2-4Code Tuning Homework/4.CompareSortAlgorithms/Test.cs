namespace TestSorting
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Test
    {
        // TEST the three sorting algorimths with thre types (string, int, double) of data and three types of array (Random, Sorted Ascending and Sorted Descending)
        public static void Main()
        {
            Random random = new Random();

            TestAlgorithmsForStringArray(random, "test random");
            TestAlgorithmsForIntArray(random, "test random");
            TestAlgorithmsForDoubleArray(random, "test random");

            TestAlgorithmsForStringArray(random, "test ascending");
            TestAlgorithmsForIntArray(random, "test ascending");
            TestAlgorithmsForDoubleArray(random, "test ascending");

            TestAlgorithmsForStringArray(random, "test descending");
            TestAlgorithmsForIntArray(random, "test descending");
            TestAlgorithmsForDoubleArray(random, "test descending");
        }

        private static void TestAlgorithmsForStringArray(Random random, string typeOfTesting)
        {
            for (int currentTestForRandomString = 0; currentTestForRandomString < 10; currentTestForRandomString++)
            {
                string[] arrayToTest = new string[20];
                if (typeOfTesting == "test random")
                {
                    Console.WriteLine("RANDOM String Values");
                    arrayToTest = CreateRandomStringArray(arrayToTest, random);
                }
                else if (typeOfTesting == "test ascending")
                {
                    Console.WriteLine("ASCENDING String Values");
                    arrayToTest = new string[] { "a", "b", "c", "d", "e", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u" };
                }
                else if (typeOfTesting == "test descending")
                {
                    Console.WriteLine("DESCENDING String Values");
                    arrayToTest = new string[] { "u", "t", "s", "r", "q", "p", "o", "n", "m", "l", "k", "j", "i", "h", "g", "e", "d", "c", "b", "a" };
                }

                Stopwatch swInsertionSort = Stopwatch.StartNew();
                SortingAlgorithms.InsertionSort(arrayToTest);
                swInsertionSort.Stop();
                Console.WriteLine(swInsertionSort.Elapsed + " <<<Insertion Sort {" + string.Join((", "), arrayToTest) + "}");

                Stopwatch swSelectingsSort = Stopwatch.StartNew();
                SortingAlgorithms.SelectingSort(arrayToTest);
                swSelectingsSort.Stop();
                Console.WriteLine(swSelectingsSort.Elapsed + " <<<Selecting Sort {" + string.Join((", "), arrayToTest) + "}");

                Stopwatch swQuicksort = Stopwatch.StartNew();
                SortingAlgorithms.QuickSortRecursive(arrayToTest, 0, arrayToTest.Length - 1);
                swQuicksort.Stop();
                Console.WriteLine(swQuicksort.Elapsed + " <<<QuickSort Algo {" + string.Join((", "), arrayToTest) + "}");
            }
        }

        private static void TestAlgorithmsForIntArray(Random random, string typeOfTesting)
        {
            for (int currentTestForRandomInt = 0; currentTestForRandomInt < 10; currentTestForRandomInt++)
            {
                int[] arrayToTest = new int[20];

                if (typeOfTesting == "test random")
                {
                    Console.WriteLine("RANDOM Int Values");
                    arrayToTest = CreateRandomIntArray(arrayToTest, random);
                }
                else if (typeOfTesting == "test ascending")
                {
                    Console.WriteLine("ASCENDING Int Values");
                    arrayToTest = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
                }
                else if (typeOfTesting == "test descending")
                {
                    Console.WriteLine("DESCENDING Int Values");
                    arrayToTest = new int[] { 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
                }

                Stopwatch swInsertionSort = Stopwatch.StartNew();
                SortingAlgorithms.InsertionSort(arrayToTest);
                swInsertionSort.Stop();
                Console.WriteLine(swInsertionSort.Elapsed + " <<<Insertion Sort {" + string.Join((", "), arrayToTest) + "}");

                Stopwatch swSelectingSort = Stopwatch.StartNew();
                SortingAlgorithms.SelectingSort(arrayToTest);
                swSelectingSort.Stop();
                Console.WriteLine(swSelectingSort.Elapsed + " <<<Selecting Sort {" + string.Join((", "), arrayToTest) + "}");

                Stopwatch swQuickSort = Stopwatch.StartNew();
                SortingAlgorithms.QuickSortRecursive(arrayToTest, 0, arrayToTest.Length - 1);
                swQuickSort.Stop();
                Console.WriteLine(swQuickSort.Elapsed + " <<<QuickSort Algo {" + string.Join((", "), arrayToTest) + "}");
            }
        }

        private static void TestAlgorithmsForDoubleArray(Random random, string typeOfTesting)
        {
            for (int currentTestForRandomDouble = 0; currentTestForRandomDouble < 10; currentTestForRandomDouble++)
            {
                double[] arrayToTest = new double[20];
                if (typeOfTesting == "test random")
                {
                    Console.WriteLine("RANDOM Double Values");
                    arrayToTest = CreateRandomDoubleArray(arrayToTest, random);
                }
                else if (typeOfTesting == "test ascending")
                {
                    Console.WriteLine("ASCENDING Double Values");
                    arrayToTest = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
                }
                else if (typeOfTesting == "test descending")
                {
                    Console.WriteLine("DESCENDING Double Values");
                    arrayToTest = new double[] { 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
                }

                Stopwatch swInsertionSort = Stopwatch.StartNew();
                SortingAlgorithms.InsertionSort(arrayToTest);
                swInsertionSort.Stop();
                Console.WriteLine(swInsertionSort.Elapsed + " <<<Insertion Sort {" + string.Join((", "), arrayToTest) + "}");

                Stopwatch swSelectingSort = Stopwatch.StartNew();
                SortingAlgorithms.SelectingSort(arrayToTest);
                swSelectingSort.Stop();
                Console.WriteLine(swSelectingSort.Elapsed + " <<<Selecting Sort {" + string.Join((", "), arrayToTest) + "}");

                Stopwatch swQuickSort = Stopwatch.StartNew();
                SortingAlgorithms.QuickSortRecursive(arrayToTest, 0, arrayToTest.Length - 1);
                swQuickSort.Stop();
                Console.WriteLine(swQuickSort.Elapsed + " <<<QuickSort Algo {" + string.Join((", "), arrayToTest) + "}");
            }
        }

        private static string[] CreateRandomStringArray(string[] stringRandomArray, Random random)
        {
            for (int randomString = 0; randomString < 20; randomString++)
            {
                int randomLength = random.Next(1, 5);
                for (int currentCharCount = 0; currentCharCount < randomLength; currentCharCount++)
                {
                    char currentChar = (char)random.Next(97, 123);
                    stringRandomArray[randomString] = stringRandomArray[randomString] + currentChar;
                }
            }

            return stringRandomArray;
        }

        private static int[] CreateRandomIntArray(int[] intRandomArray, Random random)
        {
            for (int randomInt = 0; randomInt < 20; randomInt++)
            {
                intRandomArray[randomInt] = random.Next(-100, 100);
            }

            return intRandomArray;
        }

        private static double[] CreateRandomDoubleArray(double[] doubleRandomArray, Random random)
        {
            for (int randomDouble = 0; randomDouble < 20; randomDouble++)
            {
                doubleRandomArray[randomDouble] = random.Next(-100, 100);
            }

            return doubleRandomArray;
        }
    }
}