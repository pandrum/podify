using System;
using System.Collections.Generic;
using System.Text;

namespace DL.Repositories
{
    public interface IRepository<T> where T : class
    {
        void Create(T entity);

        void Delete(int index);

        void SaveChanges();

        List<T> GetAllPodCasts();
    }
}