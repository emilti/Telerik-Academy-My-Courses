namespace StudentsSystem.Data.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IRepository<T> where T : class
    {
        void Add(T Entity);

        IQueryable<T> All();

        void Update(T Entity);

        void Delete(T Entity);

        void Detach(T Entity);

        void SaveChanges();
    }
}


