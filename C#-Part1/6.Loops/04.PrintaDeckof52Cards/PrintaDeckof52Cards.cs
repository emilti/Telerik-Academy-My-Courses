using System;

public class PrintaDeckof52Cards
{
    public static void Main()
    {
        char[] cards = { '\u2663', '\u2666', '\u2665', '\u2660' };
        for (int i = 2; i <= 14; i++)
        {
            for (int j = 0; j <= 3; j++)
            {
                switch (i)
                {
                    case 2:
                        Console.Write("{0}{1}", i, cards[j]);
                        break;
                    case 3:
                        Console.Write("{0}{1}", i, cards[j]);
                        break;
                    case 4:
                        Console.Write("{0}{1}", i, cards[j]);
                        break;
                    case 5:
                        Console.Write("{0}{1}", i, cards[j]);
                        break;
                    case 6:
                        Console.Write("{0}{1}", i, cards[j]);
                        break;
                    case 7:
                        Console.Write("{0}{1}", i, cards[j]);
                        break;
                    case 8:
                        Console.Write("{0}{1}", i, cards[j]);
                        break;
                    case 9:
                        Console.Write("{0}{1}", i, cards[j]);
                        break;
                    case 10:
                        Console.Write("{0}{1}", i, cards[j]);
                        break;
                    case 11:
                        Console.Write("J{1}", i, cards[j]);
                        break;
                    case 12:
                        Console.Write("Q{1}", i, cards[j]);
                        break;
                    case 13:
                        Console.Write("K{1}", i, cards[j]);
                        break;
                    case 14:
                        Console.Write("A{0}", cards[j]);
                        break;
                    default:
                        Console.Write("Default case");
                        break;                        
                }

                if (j == 3)
                {
                    Console.Write("\n");
                }
            }
        }
    }
}