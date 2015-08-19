using System;

public class SpiralMatrix
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int[,] spiralChar = new int[number, number];
        int countHor = 1;
        int countVer = 1;
        int countRi = 0;
        int countLe = 0;
        int countUp = 0;
        int countDo = 0;
        int overallCount = 0;
        bool isRight = true;
        bool isLeft = true;
        bool isUp = true;
        bool isDown = true;

        for (int i = 0, count = 1; i < number; i++)
        {
            while (isRight)
            {
                if (overallCount == number * number)
                {
                    break;
                }

                overallCount++;
                spiralChar[countHor - 1, countVer - 1] = count;
                count++;
                if (countVer >= number - countDo)
                {
                    countRi++;
                    isRight = false;

                    countHor++;
                }
                else
                {
                    countVer++;
                }
            }

            while (isDown)
            {
                if (overallCount == number * number)
                {
                    break;
                }

                overallCount++;
                spiralChar[countHor - 1, countVer - 1] = count;
                count++;
                if (countHor >= number - countLe)
                {
                    countDo++;
                    isDown = false;
                    countVer--;
                }
                else
                {
                    countHor++;
                }
            }

            while (isLeft)
            {
                if (overallCount == number * number)
                {
                    break;
                }

                overallCount++;
                spiralChar[countHor - 1, countVer - 1] = count;
                count++;
                if (countVer == 1 + countUp)
                {
                    countLe++;
                    isLeft = false;
                    countHor--;
                }
                else
                {
                    countVer--;
                }
            }

            while (isUp)
            {
                if (overallCount == number * number)
                {
                    break;
                }

                overallCount++;
                spiralChar[countHor - 1, countVer - 1] = count;
                count++;

                if (countHor == 1 + countRi)
                {
                    countUp++;
                    isUp = false;
                    countVer++;
                }
                else
                {
                    countHor--;
                }
            }

            if (overallCount == number * number)
            {
                break;
            }

            isRight = true;
            isLeft = true;
            isUp = true;
            isDown = true;
        }

        for (int i = 0; i < number; i++)
        {
            for (int j = 0; j < number; j++)
            {
                Console.Write("{0,5:}", spiralChar[i, j]);
            }

            Console.WriteLine();
        }
    }
}