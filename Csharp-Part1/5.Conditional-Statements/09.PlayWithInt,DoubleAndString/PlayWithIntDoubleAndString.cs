using System;

public class PlayWithIntDoubleAndString
{
    public static void Main()
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        int type = int.Parse(Console.ReadLine());
        switch (type)
        {
            case 1: Console.WriteLine("Please enter an integer:"); 
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(num + 1);
                break;
            case 2: Console.WriteLine("Please enter a double:");
                double doub = double.Parse(Console.ReadLine());
                Console.WriteLine(doub + 1);
                break;
            case 3: Console.WriteLine("Please enter a string");
                string txt = Console.ReadLine();
                Console.WriteLine("{0}*", txt);
                break;
            default: Console.WriteLine("Not 1, 2 or 3"); 
                break;
        }
    }
}