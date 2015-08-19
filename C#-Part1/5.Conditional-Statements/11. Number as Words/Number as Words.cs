using System;

public class NumberAsWords
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int thirdDigit = number % 10;
        int secondDigit = (number / 10) % 10;
        int firstDigit = number / 100;
        string hundred = null;
        string decimals = null;
        string teens = null;
        string smallNums = null;
        switch (firstDigit)
        {
            case 0: hundred = null;
                break;
            case 1: hundred = "One hundred"; 
                break;
            case 2: hundred = "Two hundred"; 
                break;
            case 3: hundred = "Three hundred"; 
                break;
            case 4: hundred = "Four hundred"; 
                break;
            case 5: hundred = "Five hundred"; 
                break;
            case 6: hundred = "Six hundred";
                break;
            case 7: hundred = "Seven hundred";
                break;
            case 8: hundred = "Eight hundred"; 
                break;
            case 9: hundred = "Nine hundred"; 
                break;
        }

        switch (secondDigit)
        {
            case 0: decimals = null;
                break;
            case 1: decimals = "Check"; 
                break;
            case 2: decimals = "Twenty"; 
                break;
            case 3: decimals = "Thirty"; 
                break;
            case 4: decimals = "Fourty"; 
                break;
            case 5: decimals = "Fifty"; 
                break;
            case 6: decimals = "Sixty"; 
                break;
            case 7: decimals = "Seventy";
                break;
            case 8: decimals = "Eighty";
                break;
            case 9: decimals = "Ninety"; 
                break;
        }

        if (decimals == "Check")
        {
            switch (thirdDigit)
            {
                case 0: teens = "Ten"; 
                    break;
                case 1: teens = "Eleven"; 
                    break;
                case 2: teens = "Twelve";
                    break;
                case 3: teens = "Thirteen";
                    break;
                case 4: teens = "Fourteen"; 
                    break;
                case 5: teens = "Fifteen";
                    break;
                case 6: teens = "Sixteen";
                    break;
                case 7: teens = "Seventeen"; 
                    break;
                case 8: teens = "Eighteen"; 
                    break;
                case 9: teens = "Nineteen";
                    break;
            }
        }

        switch (thirdDigit)
        {
            case 0: smallNums = null; 
                break;
            case 1: smallNums = "One"; 
                break;
            case 2: smallNums = "Two";
                break;
            case 3: smallNums = "Three"; 
                break;
            case 4: smallNums = "Four";
                break;
            case 5: smallNums = "Five";
                break;
            case 6: smallNums = "Six"; 
                break;
            case 7: smallNums = "Seven"; 
                break;
            case 8: smallNums = "Eight";
                break;
            case 9: smallNums = "Nine";
                break;          
        }

        if (number < 10 && number > 0)
        {
            Console.WriteLine("{0}", smallNums);
        }
        else if (number == 0)
        {
            Console.WriteLine("Zero");
        }
        else if (number >= 10 && number < 20)
        {
            Console.WriteLine("{0}", teens);
        }
        else if (number >= 20 && number < 99 && thirdDigit != 0)
        {
            Console.WriteLine("{0} {1}", decimals, smallNums);            
        }
        else if (number >= 20 && number < 99 && thirdDigit == 0)
        {
            Console.WriteLine("{0}", decimals);            
        }
        else if (number >= 99 && number <= 999 && thirdDigit != 0 && secondDigit != 0 && secondDigit != 1)
        {
            Console.WriteLine("{0} and {1} {2}", hundred, decimals, smallNums);         
        }
        else if (number >= 99 && number < 999 && secondDigit == 1)
        {
            Console.WriteLine("{0} and {1}", hundred, teens);
        }
        else if (number >= 99 && number < 999 && thirdDigit == 0 && secondDigit != 0)
        {
            Console.WriteLine("{0} and {1}", hundred, decimals);
        }
        else if (number >= 99 && number < 999 && thirdDigit == 0 && secondDigit == 0)
        {
            Console.WriteLine("{0}", hundred);
        }
        else if (number >= 99 && number < 999 && thirdDigit != 0 && secondDigit == 0)
        {
            Console.WriteLine("{0} and {1}", hundred, smallNums);
        }
    }
}