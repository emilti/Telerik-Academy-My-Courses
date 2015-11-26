using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Salaries
{
    class Program
    {
        public static long[] cache;
        public static bool[,] adjMatrix;
        public static int employees;

        static void Main(string[] args)
        {
            employees = int.Parse(Console.ReadLine());
            adjMatrix = new bool[employees, employees];
            cache = new long[employees];

            for (int i = 0; i < employees; i++)
            {
                string line = Console.ReadLine();

                for (int j = 0; j < employees; j++)
                {
                    adjMatrix[i, j] = (line[j] == 'Y');
                }
            }

            // Sum all salaries
            long sumOfSalaries = 0;
            for (int i = 0; i < employees; i++)
            {
                sumOfSalaries += findSalary(i);
            }

            Console.WriteLine(sumOfSalaries);
        }

        public static long findSalary(int employee)
        {
            if (cache[employee] > 0)
            {
                return cache[employee];
            }

            long salary = 0;
            for (int i = 0; i < employees; i++)
            {
                if (adjMatrix[employee, i])
                {
                    salary += findSalary(i);
                }
            }
            if (salary == 0) salary = 1;
            cache[employee] = salary;
            return salary;
        }
    }
}
