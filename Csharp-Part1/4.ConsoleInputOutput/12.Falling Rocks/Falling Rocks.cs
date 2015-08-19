using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

public struct Rock
{
    public int x;
    public int y;
    public char c;
    public ConsoleColor color;
}

public struct Dwarf
{
    public int x;
    public int y;
    public string str;
    public ConsoleColor color;
}

public class FallingRocks
{
    public static void PrintFallingRocs(int x, int y, char c, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }
    public static void PrintString(int x, int y, string str, ConsoleColor color = ConsoleColor.Blue)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(str);
    }

    public static void Main()
    {
        int field = 50;
        Console.BufferHeight = Console.WindowHeight = 50;
        Console.BufferWidth = Console.WindowWidth = 61;
        Dwarf userDwarf = new Dwarf();
        int livesCount = 5;
        userDwarf.x = 30;
        userDwarf.y = Console.WindowHeight - 1;
        userDwarf.str = "(0)";
        userDwarf.color = ConsoleColor.Yellow;
        Random randomGenerator = new Random();
        List<object> objects = new List<object>();
        while (true)
        {
            bool hitted = false;

            // ^  @  *  &  +  %  $  # !  . ; -
            for (int index = 0; index < 3; index++)
            {
                int chance = randomGenerator.Next(0, 2);
                if (chance == 0)
                {
                    Rock newObject = new Rock();
                    newObject.color = ConsoleColor.DarkRed;
                    newObject.c = '^';
                    newObject.x = randomGenerator.Next(0, field);
                    newObject.y = 0;
                    objects.Add(newObject);
                }
                else if (chance == 1)
                {
                    Rock newObject = new Rock();
                    newObject.color = ConsoleColor.Cyan;
                    newObject.c = '@';
                    newObject.x = randomGenerator.Next(0, field);
                    newObject.y = 0;
                    objects.Add(newObject);
                }
                else
                {
                    Rock newCar = new Rock();
                    newCar.color = ConsoleColor.Green;
                    newCar.x = randomGenerator.Next(0, field);
                    newCar.y = 0;
                    newCar.c = '*';
                    objects.Add(newCar);
                }
            }
            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);

                // while (Console.KeyAvailable) Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (userDwarf.x - 1 >= 0)
                    {
                        userDwarf.x = userDwarf.x - 1;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (userDwarf.x + 3 < field)
                    {
                        userDwarf.x = userDwarf.x + 1;
                    }
                }
            }

            List<object> newList = new List<object>();
            for (int i = 0; i < objects.Count; i++)
            {
                Rock oldRock = (Rock)objects[i];
                Rock newObject = new Rock();
                newObject.x = oldRock.x;
                newObject.y = oldRock.y + 1;
                newObject.c = oldRock.c;
                newObject.color = oldRock.color;
                if ((newObject.c == '@' || newObject.c == '^') &&
                    newObject.y == userDwarf.y &&
                    (newObject.x == userDwarf.x ||
                    newObject.x == userDwarf.x + 1 ||
                    newObject.x == userDwarf.x + 2))
                {
                    livesCount--;
                    hitted = true;
                }

                if (livesCount <= 0)
                {
                    PrintString(12, 20, "GAME OVER!!!", ConsoleColor.Red);
                    PrintString(8, 12, "Press [enter] to exit", ConsoleColor.Red);
                    Console.ReadLine();
                    Environment.Exit(0);
                }

                if (newObject.y < Console.WindowHeight)
                {
                    newList.Add(newObject);
                }
            }
            objects = newList;
            Console.Clear();
            hitted = false;
            foreach (Rock rock in objects)
            {
                PrintFallingRocs(rock.x, rock.y, rock.c, rock.color);
            }
            PrintString(50, 4, "Lives: " + livesCount, ConsoleColor.White);
            PrintString(userDwarf.x, userDwarf.y, userDwarf.str, userDwarf.color);
            Thread.Sleep(200);
        }
    }
}