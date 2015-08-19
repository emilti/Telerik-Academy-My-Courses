using System;
using System.Linq;

public class Task06
{
    public static void Main()
    {
        int[] array = { 2, 3, 4, 42, 5, 7, 8, 9, 10, 21 };
        int[] arrayTargetLambda = array.Where(x => x % 7 == 0 && x % 3 == 0).ToArray();
        Console.WriteLine(string.Join(", ", arrayTargetLambda));
        var arrayTargetLINQ = from num in array
                                  where (num % 3 == 0 && num % 7 == 0)
                                  select num;
        Console.WriteLine(string.Join(", ", arrayTargetLINQ));
    }
}
