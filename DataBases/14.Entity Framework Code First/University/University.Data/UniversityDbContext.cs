namespace University.Data
{
    using System.Data.Entity;
    using University.Models;

    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext()
            : base("UniversitySystem")
        {
        }

        public IDbSet<Course> Courses { get; set; }

        public IDbSet<Homework> Homeworks { get; set; }

        public IDbSet<Student> Students { get; set; }
    }
}
