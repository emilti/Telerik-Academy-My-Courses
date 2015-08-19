using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NumberAsArray
{
    public static void Main()
    {
        Console.WriteLine("Enter two integer numbers:");
        string numberX = Console.ReadLine();
        string numberY = Console.ReadLine();
        List<char> arrayX = numberX.ToList();
        List<char> arrayY = numberY.ToList(); 
        string result = Adding(arrayX, arrayY);
        Console.WriteLine("The result of adding the two numbers is:");
        Console.WriteLine(result);
    }
    
    public static string Adding(List<char> arrayX, List<char> arrayY)
    {
        arrayX.Reverse();
        arrayY.Reverse();
        bool xIsBigger = arrayX.Count > arrayY.Count;
        if (xIsBigger)
        {
            for (int i = arrayY.Count; i < arrayX.Count; i++)
            {
                arrayY.Add('0');
            }            
        }
        else
        {
            for (int i = arrayX.Count; i < arrayY.Count; i++)
            {
                arrayX.Add('0');
            }  
        }

        List<int> comb = new List<int>();
        int adding = 0;
        for (int i = 0; i < arrayY.Count; i++)
        {
            int temp = arrayX[i] + arrayY[i] - 96;
            comb.Insert(i, temp + adding);
            if (comb[i] > 9)
            {
                adding = 1;
                comb[i] = comb[i] - 10;
            }
            else
            {
                adding = 0;
            }

            if (adding == 1 && i == arrayX.Count - 1)
            {
                comb.Add(1);
            }
        }

        string rawString = string.Join(string.Empty, comb);
        string reversedString = Reverse(rawString);
        string finalNum = reversedString;
        return finalNum;
    }

    public static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}