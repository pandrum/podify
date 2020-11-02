using System.Collections.Generic;

namespace DL.Repositories
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
    }
}