namespace University.ConsoleClient
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using University.Data;
    using University.Data.Migrations;
    using University.Models;
    public class Startup
    {
        public static void Main()
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<UniversityDbContext, Configuration>());
            var db = new UniversityDbContext();
            // var course = new Course
            // {
            //     Name = "Random course",
            //     Desctiption = "Here is the Description."
            // };
            // 
            // db.Courses.Add(course);
            // db.SaveChanges();
            Console.WriteLine(db.Courses.Count());
        }
    }
}
