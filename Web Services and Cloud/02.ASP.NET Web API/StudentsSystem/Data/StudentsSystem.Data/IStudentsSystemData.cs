namespace StudentSystem.Data
{    
    using StudentsSystem.Data.Repositories;
    using Models;

    public interface IStudentsSystemData
    {
        IRepository<Course> Courses { get; }

        IRepository<Student> Students { get; }

        IRepository<Homework> Homeworks { get; }

        void SaveChanges();
    }
}