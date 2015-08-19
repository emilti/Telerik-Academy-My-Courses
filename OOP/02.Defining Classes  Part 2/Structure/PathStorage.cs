namespace Point
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public static class PathStorage
    {
        public static List<Path> LoadPath(string filePath)
        {
            StreamReader reader = new StreamReader(string.Empty + filePath + string.Empty);
            List<Path> collectionOfPathsFromText = new List<Path>();
            string input = "Start";
            using (reader)
            {
                while (input != string.Empty)
                {
                    input = reader.ReadLine();
                    Path newPathFromText = new Path();
                    while (input != "End of Path" && input != "Start" && input != null)
                    {
                        Point3D currentPoint = new Point3D();
                        double[] pointCoord = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                        currentPoint.PointX = pointCoord[0];
                        currentPoint.PointY = pointCoord[1];
                        currentPoint.PointZ = pointCoord[2];
                        newPathFromText.PointsCollection.Add(currentPoint);
                        input = reader.ReadLine();
                    }

                    if (input == null)
                    {
                        break;
                    }

                    collectionOfPathsFromText.Add(newPathFromText);
                }

                return collectionOfPathsFromText;
            }
        }

        public static void SavePath(string filePath, List<Path> collectionOfPaths)
        {
            StreamWriter writer = new StreamWriter(@"..\..\paths.txt");
            using (writer)
            {
                for (int i = 0; i < collectionOfPaths.Count; i++)
                {
                    for (int j = 0; j < collectionOfPaths[i].PointsCollection.Count; j++)
                    {
                        writer.WriteLine("{0} {1} {2}", collectionOfPaths[i].PointsCollection[j].PointX, collectionOfPaths[i].PointsCollection[j].PointY, collectionOfPaths[i].PointsCollection[j].PointZ);

                        if (j == collectionOfPaths[i].PointsCollection.Count - 1)
                        {
                            writer.WriteLine("End of Path");
                        }
                    }
                }
            }
        }
    }
}
