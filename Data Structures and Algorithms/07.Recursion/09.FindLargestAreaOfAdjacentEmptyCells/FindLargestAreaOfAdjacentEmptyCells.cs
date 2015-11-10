namespace Recursion
{
    /// <summary>
    /// 09.Write a recursive program to find the largest connected area of adjacent empty cells in a matrix.
    /// </summary>
    namespace FindLargestConnectedAreaOfAdjacentCells
    {
        using System;
        using System.Collections.Generic;

        public class Startup
        {
            private static string[,] matrix = new string[,]
            {
            { "0", "0","0","x","0","x" },
            { "0", "x","0","x","0","x" },
            { "0", "*","x","0","x","0" },
            { "0", "x","0","0","0","0" },
            { "0", "0","0","x","x","0" },
            { "0", "0","0","x","0","x" }
            };

            private static void Main()
            {
                var answer = TraverseBFS(2, 1);
                Console.WriteLine("The largest area of adjacent cell is {0}", answer);
            }

            private static int TraverseBFS(int startRow, int startColumn)
            {
                var queue = new Queue<Index>();
                var root = new Index { Row = startRow, Column = startColumn, Value = 0 };
                var result = 0;
                queue.Enqueue(root);
                while (queue.Count != 0)
                {
                    var currRoot = queue.Dequeue();
                    matrix[currRoot.Row, currRoot.Column] = currRoot.Value.ToString();
                    currRoot.Value++;

                    result = Math.Max(result, currRoot.Value);
                    if (currRoot.Row + 1 < matrix.GetLength(0) && matrix[currRoot.Row + 1, currRoot.Column] == "0")
                    {
                        currRoot.Children.Add(new Index { Row = currRoot.Row + 1, Column = currRoot.Column, Value = currRoot.Value });
                    }

                    if (currRoot.Row - 1 >= 0 && matrix[currRoot.Row - 1, currRoot.Column] == "0")
                    {
                        currRoot.Children.Add(new Index { Row = currRoot.Row - 1, Column = currRoot.Column, Value = currRoot.Value });
                    }

                    if (currRoot.Column + 1 < matrix.GetLength(0) && matrix[currRoot.Row, currRoot.Column + 1] == "0")
                    {
                        currRoot.Children.Add(new Index { Row = currRoot.Row, Column = currRoot.Column + 1, Value = currRoot.Value });
                    }

                    if (currRoot.Column - 1 >= 0 && matrix[currRoot.Row, currRoot.Column - 1] == "0")
                    {
                        currRoot.Children.Add(new Index { Row = currRoot.Row, Column = currRoot.Column - 1, Value = currRoot.Value });
                    }

                    foreach (var index in currRoot.Children)
                    {
                        queue.Enqueue(index);
                    }
                }

                return result;
            }
        }
    }
}