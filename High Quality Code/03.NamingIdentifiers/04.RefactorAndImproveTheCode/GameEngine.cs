namespace Minesweeper
{
    using System;
    using System.Collections.Generic;

    public class GameEngine
    {
        public static void Main(string[] args)
        {
            string command = string.Empty;
            char[,] field = CreateInitialBoard();
            char[,] bombs = BombPlacer();
            int counter = 0;
            bool isMine = false;
            List<Player> champions = new List<Player>(6);
            int row = 0;
            int col = 0;
            bool isBegining = true;
            const int MAX = 35;
            bool allMinesAvoided = false;

            do
            {
                if (isBegining)
                {
                    Console.WriteLine("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
                    " Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
                    DrawBoard(field);
                    isBegining = false;
                }

                Console.Write("Daj red i kolona : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out col) &&
                        row <= field.GetLength(0) && col <= field.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        Ranking(champions);
                        break;
                    case "restart":
                        field = CreateInitialBoard();
                        bombs = BombPlacer();
                        DrawBoard(field);
                        isMine = false;
                        isBegining = false;
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        if (bombs[row, col] != '*')
                        {
                            if (bombs[row, col] == '-')
                            {
                                CalculationsBeforeMove(field, bombs, row, col);
                                counter++;
                            }

                            if (MAX == counter)
                            {
                                allMinesAvoided = true;
                            }
                            else
                            {
                                DrawBoard(field);
                            }
                        }
                        else
                        {
                            isMine = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nGreshka! nevalidna Komanda\n");
                        break;
                }

                if (isMine)
                {
                    DrawBoard(bombs);
                    Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " + "Daj si niknejm: ", counter);
                    string nickname = Console.ReadLine();
                    Player currentPlayer = new Player(nickname, counter);
                    if (champions.Count < 5)
                    {
                        champions.Add(currentPlayer);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].PointsCount < currentPlayer.PointsCount)
                            {
                                champions.Insert(i, currentPlayer);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort((Player r1, Player r2) => r2.Name.CompareTo(r1.Name));
                    champions.Sort((Player r1, Player r2) => r2.PointsCount.CompareTo(r1.PointsCount));
                    Ranking(champions);

                    field = CreateInitialBoard();
                    bombs = BombPlacer();
                    counter = 0;
                    isMine = false;
                    isBegining = true;
                }

                if (allMinesAvoided)
                {
                    Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
                    DrawBoard(bombs);
                    Console.WriteLine("Daj si imeto, batka: ");
                    string name = Console.ReadLine();
                    Player currentPlayer = new Player(name, counter);
                    champions.Add(currentPlayer);
                    Ranking(champions);
                    field = CreateInitialBoard();
                    bombs = BombPlacer();
                    counter = 0;
                    allMinesAvoided = false;
                    isBegining = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        private static void Ranking(List<Player> points)
        {
            Console.WriteLine("\nTo4KI:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii", i + 1, points[i].Name, points[i].PointsCount);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("prazna klasaciq!\n");
            }
        }

        private static void CalculationsBeforeMove(char[,] field, char[,] bombs, int row, int col)
        {
            char countOfBombs = CalculateBombsInNeighbouringSquares(bombs, row, col);
            bombs[row, col] = countOfBombs;
            field[row, col] = countOfBombs;
        }

        private static void DrawBoard(char[,] board)
        {
            int rowLength = board.GetLength(0);
            int colLength = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rowLength; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateInitialBoard()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] BombPlacer()
        {
            int rows = 5;
            int cols = 10;
            char[,] playField = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    playField[i, j] = '-';
                }
            }

            List<int> countOfBombsToBePlaced = new List<int>();
            while (countOfBombsToBePlaced.Count < 15)
            {
                Random random = new Random();
                int randomNumber = random.Next(50);
                if (!countOfBombsToBePlaced.Contains(randomNumber))
                {
                    countOfBombsToBePlaced.Add(randomNumber);
                }
            }

            foreach (int bomb in countOfBombsToBePlaced)
            {
                int col = bomb / cols;
                int row = bomb % cols;
                if (row == 0 && bomb != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }

                playField[col, row - 1] = '*';
            }

            return playField;
        }

        private static void Calculations(char[,] field)
        {
            int col = field.GetLength(0);
            int row = field.GetLength(1);

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (field[i, j] != '*')
                    {
                        char countOfBombs = CalculateBombsInNeighbouringSquares(field, i, j);
                        field[i, j] = countOfBombs;
                    }
                }
            }
        }

        private static char CalculateBombsInNeighbouringSquares(char[,] field, int row, int col)
        {
            int countOfBombsInNeighbouringSquares = 0;
            int rows = field.GetLength(0);
            int cols = field.GetLength(1);

            if (row - 1 >= 0)
            {
                if (field[row - 1, col] == '*')
                {
                    countOfBombsInNeighbouringSquares++;
                }
            }

            if (row + 1 < rows)
            {
                if (field[row + 1, col] == '*')
                {
                    countOfBombsInNeighbouringSquares++;
                }
            }

            if (col - 1 >= 0)
            {
                if (field[row, col - 1] == '*')
                {
                    countOfBombsInNeighbouringSquares++;
                }
            }

            if (col + 1 < cols)
            {
                if (field[row, col + 1] == '*')
                {
                    countOfBombsInNeighbouringSquares++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (field[row - 1, col - 1] == '*')
                {
                    countOfBombsInNeighbouringSquares++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (field[row - 1, col + 1] == '*')
                {
                    countOfBombsInNeighbouringSquares++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (field[row + 1, col - 1] == '*')
                {
                    countOfBombsInNeighbouringSquares++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (field[row + 1, col + 1] == '*')
                {
                    countOfBombsInNeighbouringSquares++;
                }
            }

            return char.Parse(countOfBombsInNeighbouringSquares.ToString());
        }
    }
}
