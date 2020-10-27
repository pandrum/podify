using System;
using System.Collections.Generic;
using System.Text;

namespace DL.Repositories
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
    }
}