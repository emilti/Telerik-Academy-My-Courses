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

            int numberOfHomeworksPerStudent = 5;
            AddRandomStudents(context, random);
            AddRandomCourses(context, random);
            AddRandomHomeworks(context, numberOfHomeworksPerStudent, random);
                     
        }
        private static void AddRandomStudents(UniversityDbContext context, Random random)
        {
            for (int i = 0; i < 10; i++)
            {
                context.Students.AddOrUpdate(
              a => a.StudentId,
             new Student
             {
                 Name = "Student name" + GetRandomString(random),
                 Address = "Adress" + GetRandomString(random),
                 Age = random.Next(18, 99),
                 StudentNumber = random.Next(11111, 99999)
                 // Courses = selectedCourses
             });
            }
        }

        private static void AddRandomCourses(UniversityDbContext context, Random random)
        {
            for (int i = 0; i < 10; i++)
            {
                context.Courses.AddOrUpdate(
                a => a.CourseId,
               new Course
               {
                   Name = "name:" + GetRandomString(random),
                   Desctiption = "Descritption:" + GetRandomString(random)
               });
            }
        }

        private static void AddRandomHomeworks(UniversityDbContext context, int numberOfHomeworksPerStudent, Random random)
        {
            var studentsDb = context.Students.ToList();  
            foreach (var student in studentsDb)
            {
                Console.WriteLine(student.StudentId);
                var randomCourse = random.Next(1, context.Courses.Count()); 
                var allCourses = context.Courses.ToList();                
                for (int j = 0; j < numberOfHomeworksPerStudent; j++)
                {
                    var HomeworkToAdd = new Homework
                    {
                        Content = "Homework name " + GetRandomString(random),
                        TimeSent = DateTime.Now,
                        StudentId = student.StudentId,
                        CourseId = allCourses[randomCourse].CourseId
                    };

                    context.Homeworks.Add(HomeworkToAdd);
                }
            }
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
