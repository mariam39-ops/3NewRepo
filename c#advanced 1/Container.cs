using System;
using System.Collections.Generic;
using System.Text;

namespace c_advanced_1
{
    //answer2
    internal class Container<T>
    {
        T value;
        public void add( T y)
        {
            value = y;
        } public T get()
        {
            return value;
        }

    }
}
