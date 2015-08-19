using System;
using System.Collections.Generic;

public class CompareChar
{
    public static void Main()
    {
        List<char> listOfChar1 = new List<char>();
        List<char> listOfChar2 = new List<char>();
        bool isEqual = false;
        Console.WriteLine("Enter the first array (enter \"end\" when you want to end it)");
        for (int i = 0; i < 1;)
        {
            string type = Console.ReadLine();
            i = (type == "end") ? 1 : 0;
            if (type == "end")
            {
                break;
            }
            else
            {
                listOfChar1.Add(char.Parse(type));
            }
        }

        Console.WriteLine("Enter the second array (enter \"end\" when you want to end it)");
        for (int i = 0; i < 1;)
        {
            string type = Console.ReadLine();
            i = (type == "end") ? 1 : 0;
            if (type == "end")
            {
                break;
            }
            else
            {
                listOfChar2.Add(char.Parse(type));
            }
        }

        isEqual = listOfChar1.Count != listOfChar2.Count ? false : true;
        if (listOfChar1.Count == listOfChar2.Count)
        {            
            for (int index = 0; index < listOfChar1.Count; index++)
            {
                if (listOfChar1[index] != listOfChar2[index])
                {
                    isEqual = false;     
                }
            }           
        }

        if (isEqual == true)
        {
            Console.WriteLine("Two arrays are equal");
        }
        else
        {
            Console.WriteLine("Two arrays are NOT equal");
        }
    }
}
