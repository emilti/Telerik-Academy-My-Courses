namespace FriendsOfPesho
{
    using System;
    using System.Collections.Generic;

    public class MainProgram
    {
        public static void Main(string[] args)
        {
            string[] inputNumbers = Console.ReadLine().Split(' ');
            int pointsNumber = int.Parse(inputNumbers[0]);
            int streetsumbers = int.Parse(inputNumbers[1]);
            int hospitalNumbers = int.Parse(inputNumbers[2]);
            string[] allHospitals = Console.ReadLine().Split(' ');

            Dictionary<Node, List<Connection>> graph = new Dictionary<Node, List<Connection>>();
            Dictionary<int, Node> allNodes = new Dictionary<int, Node>();
            for (int i = 0; i < streetsumbers; i++)
            {
                string[] currentStreet = Console.ReadLine().Split(' ');
                int firstNode = int.Parse(currentStreet[0]);
                int secondNode = int.Parse(currentStreet[1]);
                int distance = int.Parse(currentStreet[2]);

                if (!allNodes.ContainsKey(firstNode))
                {
                    allNodes.Add(firstNode, new Node(firstNode));
                }

                if (!allNodes.ContainsKey(secondNode))
                {
                    allNodes.Add(secondNode, new Node(secondNode));
                }

                Node firstNodeObject = allNodes[firstNode];
                Node secondNodeObject = allNodes[secondNode];
                if (!graph.ContainsKey(firstNodeObject))
                {
                    graph.Add(firstNodeObject, new List<Connection>());
                }

                if (!graph.ContainsKey(secondNodeObject))
                {
                    graph.Add(secondNodeObject, new List<Connection>());
                }

                graph[firstNodeObject].Add(new Connection(secondNodeObject, distance));
                graph[secondNodeObject].Add(new Connection(firstNodeObject, distance));
            }

            for (int i = 0; i < allHospitals.Length; i++)
            {
                int currentHospital = int.Parse(allHospitals[i]);
                allNodes[currentHospital].IsHosital = true;
            }

            long result = long.MaxValue;
            for (int i = 0; i < allHospitals.Length; i++)
            {
                int currentHospital = int.Parse(allHospitals[i]);
                DijkstraAlgorithm(graph, allNodes[currentHospital]);
                long temporarySum = 0;
                foreach (var node in allNodes)
                {
                    if (!node.Value.IsHosital)
                    {
                        temporarySum += node.Value.DijkstraDistance;
                    }
                }

                if (temporarySum < result)
                {
                    result = temporarySum;
                }
            }

            Console.WriteLine(result);
        }

        public static void DijkstraAlgorithm(Dictionary<Node, List<Connection>> graph, Node source)
        {
            PriorityQueue<Node> queue = new PriorityQueue<Node>();
            foreach (var node in graph)
            {
                node.Key.DijkstraDistance = long.MaxValue;
            }

            source.DijkstraDistance = 0;
            queue.Enqueue(source);

            while (queue.Count != 0)
            {
                Node currentNode = queue.Dequeue();
                if (currentNode.DijkstraDistance == long.MaxValue)
                {
                    break;
                }

                foreach (var connection in graph[currentNode])
                {
                    var potDistance = currentNode.DijkstraDistance + connection.Distance;
                    if (potDistance < connection.ToNode.DijkstraDistance)
                    {
                        connection.ToNode.DijkstraDistance = potDistance;
                        queue.Enqueue(connection.ToNode);
                    }
                }
            }
        }
    }   
}