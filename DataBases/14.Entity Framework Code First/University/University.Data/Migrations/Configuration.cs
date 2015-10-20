namespace University.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using University.Models;

    public sealed class Configuration : DbMigrationsConfiguration<UniversityDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            ContextKey = "University.Data.UniversityDbContext";
        }

        protected override void Seed(UniversityDbContext context)
        {
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {               
                context.Courses.AddOrUpdate(
                 a => a.Id,
                new Course
                {
                    Name =  "name:"+GetRandomString(random),
                    Desctiption = "Descritption:" + GetRandomString(random)
                });


                context.Students.AddOrUpdate(
                 a => a.Id,
                new Student
                {
                    Name = "Student name" + GetRandomString(random),
                    Address = "Adress" + GetRandomString(random),
                    Age = 18,
                    // Courses = selectedCourses
                });
                context.Homeworks.AddOrUpdate(
                 a => a.Id,
                 new Homework
                {
                    Content = "Homework name" + GetRandomString(random),
                    TimeSent = DateTime.Now   
                    
                });
            }

           
               var courseForRemoving = context.Courses.Where(a => a.Id > 0);
               
           
        }

        private static string GetRandomString(Random random)
        {
            
            int length = random.Next(5, 10);
            string sequence = string.Empty;
            for (int j = 0; j < length; j++)
            {                
                int letter = random.Next(97, 124);
                sequence = sequence + (char)letter;
            }
            return sequence;
        }        
    }
}
