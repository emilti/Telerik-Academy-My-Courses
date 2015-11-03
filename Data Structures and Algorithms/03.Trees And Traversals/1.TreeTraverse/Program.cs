namespace TreeTraverse
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            int m = int.Parse(Console.ReadLine());
            var nodes = new Node<int>[m];
            for (int i = 0; i < m; i++)
			{
                nodes[i] = new Node<int>(i);
			}

            for (int i = 1; i < m ; i++)
            {
                string inputRow = Console.ReadLine();
                var separatedRow = inputRow.Split(' ');
                var parentId = int.Parse(separatedRow[0]);
                var childId = int.Parse(separatedRow[1]);              
                nodes[parentId].Children.Add(nodes[childId]);                
            }

            var hasParent = new bool[m];
            
            // Task A: Find Root
            var root = FindRoot(nodes, hasParent);
            Console.WriteLine("The root node is:{0}", root.Value);
            
            // Task B: Find Leafs
            var leafs = new List<Node<int>>();
            FindLeafs(nodes, leafs);
            Console.WriteLine("The leafs are:");
            Console.WriteLine(string.Join(",", leafs));
            
            // Task C: Find Middle Nodes
            var middleNodes = new List<Node<int>>();
            FindMiddleNodes(nodes, hasParent, middleNodes);
            Console.WriteLine("The middle nodes are:");
            Console.WriteLine(string.Join(",", middleNodes));
            
            // Task D: Find Longest Path
            int longestPath = FindLongestPath(FindRoot(nodes, hasParent));
            Console.WriteLine("The longest path is: {0}.", longestPath);
            
            // Task E: all paths in the tree with given sum S of their nodes
            int searchedSum = int.Parse(Console.ReadLine());
            List<Node<int>> currentPath = new List<Node<int>>();
            List<List<Node<int>>> paths = new List<List<Node<int>>>();
            var MyNodes = DFS(FindRoot(nodes, hasParent), searchedSum, currentPath, paths);
       
        }


        private static List<List<Node<int>>> DFS(Node<int> node, int searchedSum,  List<Node<int>> currentPath, List<List<Node<int>>> paths)
        {            
            foreach (var child in node.Children)
            {
                if (searchedSum - child.Value == 0 && child.Children.Count == 0)
                {
                    paths.Add(currentPath);
                }
                DFS(child, searchedSum - child.Value, currentPath, paths);
                currentPath.Add(child);
            }

            return paths;
        }
        private static int FindLongestPath(Node<int> root)
        {
            if (root.Children.Count == 0)
            {
                return 0;
            }

            int maxPath = 0;
            foreach (var node in root.Children)
            {
                maxPath = Math.Max(maxPath, FindLongestPath(node));
            }

            maxPath += 1;
            return maxPath;
        }

        private static void FindMiddleNodes(Node<int>[] nodes, bool[] hasParent, List<Node<int>> middleNodes)
        {
            for (int r = 0; r < nodes.Length; r++)
            {
                if (nodes[r].Children.Count > 0 && hasParent[r] == true)
                {
                    middleNodes.Add(nodes[r]);
                }
            }
        }

        private static void FindLeafs(Node<int>[] nodes, List<Node<int>> leafs)
        {
            for (int p = 0; p < nodes.Length; p++)
            {
                if (nodes[p].Children.Count == 0)
                {
                    leafs.Add(nodes[p]);
                }
            }
        }       

        private static Node<int> FindRoot(Node<int>[] nodes, bool[] hasParent)
        {
            Node<int> rootNode = new Node<int>(); 
            for (int j = 0; j < nodes.Length; j++)
            {
                var children = nodes[j].Children;
                foreach (var node in children)
                {
                    hasParent[node.Value] = true;
                }
            }


            for (int k = 0; k < hasParent.Length; k++)
            {
                if (hasParent[k] == false)
                {
                    rootNode = nodes[k];
                }
            }

            return rootNode;
        }
    }
}
