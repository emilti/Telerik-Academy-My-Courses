using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CorrectBrackets
{
    public static void Main()
    {
        Console.WriteLine("Enter math expression:");
        string input = ")(a+b))";
        Console.WriteLine(input);

        // string input = "((a+b)/5-d)";
        bool incorrect = false;
        if (input.IndexOf('(') > input.IndexOf(')'))
        {
            incorrect = true;
        }

        Console.WriteLine("The brackets are put correctly:{0}", !incorrect);        
    }
}