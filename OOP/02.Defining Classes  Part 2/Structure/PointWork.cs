namespace Point
{
    using System;
    using System.Collections.Generic;     
  
    public class PointWork
    {
        public static void CreatePoint()
        {
            Console.WriteLine("Examplary points");
            Point3D pointInput1 = new Point3D(-7, -4, 3);
            Point3D pointInput2 = new Point3D(17, 6, 2.5);
            Console.WriteLine("Point A:");
            Console.WriteLine(pointInput1);
            Console.WriteLine("Point B:");
            Console.WriteLine(pointInput2);
            double distance = DistanceCalculation.Distance(pointInput1, pointInput2);
            Console.WriteLine("The distance between point A and point B is:");
            Console.WriteLine(distance);
            string filePath = "../../Paths.txt";

            List<Path> listOfPaths = new List<Path>();
            while (true)
            {
                Console.WriteLine("Do you want to create a new path:");
                string input = Console.ReadLine();
                if (input == "Yes")
                {
                    Path newPath = new Path();
                    newPath.PointsCollection = newPath.AddPath();                    
                    listOfPaths.Add(newPath);
                   
                    PathStorage.SavePath(filePath, listOfPaths);
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("The text files paths.txt is in the folder called \"Structure\".");

            // The paths from the text file are here:
            List<Path> listOfRecordedPaths = PathStorage.LoadPath(filePath);         
        }

        public static void Main()
        {
            CreatePoint();
        }
    }   
}