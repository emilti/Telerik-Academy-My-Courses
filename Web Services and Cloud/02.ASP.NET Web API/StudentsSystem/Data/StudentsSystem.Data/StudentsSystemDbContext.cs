namespace StudentsSystem.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using StudentSystem.Models;
    using System.Data.Entity;

    public class StudentsSystemDbContext : IdentityDbContext<User>, IStudentSystemDbContext
    {
        public StudentsSystemDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public virtual IDbSet<Homework> Homeworks { get; set; }

        public virtual IDbSet<Course> Courses { get; set; }

        public virtual IDbSet<Student> Students { get; set; }

        public new void SaveChanges()
        {
            base.SaveChanges();
        }

        public static StudentsSystemDbContext Create()
        {
            return new StudentsSystemDbContext();
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
    }
}
