using System;
using System.Collections.Generic;
using System.Text;

namespace DL.Repositories
{
    public interface IRepository<T>
    {
        void delete(int index);

        void add(int index);

      
    }
}
