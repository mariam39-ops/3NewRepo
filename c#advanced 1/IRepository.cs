using System;
using System.Collections.Generic;
using System.Text;

namespace c_advanced_1
{//answer 6
    internal interface IRepository<T>
    {
        void Add(T item);

        T Get(int id);

        void Delete(int id);
    }
}
