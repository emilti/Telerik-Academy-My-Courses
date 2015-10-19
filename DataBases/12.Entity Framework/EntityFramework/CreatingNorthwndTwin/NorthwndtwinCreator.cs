namespace CreateNorthwindTwin
{
    using System;
    using WorkWithNortwnd;

    public class NorthwndtwinCreator
    {
        public static void Main()
        {
            using (var northwindEntities = new NorthwindEntities())
            {
                // Change in the app.config file the connection string to:
                // initial catalog=NorthwindTwin
                var result = northwindEntities.Database.CreateIfNotExists();

                Console.WriteLine("Database NorthWindTwin is created: {0}", result ? "YES!" : "NO!");
            }            
        }
    }
}