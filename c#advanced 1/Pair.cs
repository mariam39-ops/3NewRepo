using System;
using System.Collections.Generic;
using System.Text;

namespace c_advanced_1
{
    //answer3
    internal class Pair<Tkey,Tvalue>
    {
        Tkey key;
        Tvalue value;

        public void Add(Tkey k,Tvalue v) {
            key = k;
            value = v;
        }
        public void print()
        {
            Console.WriteLine(key);
            Console.WriteLine(value);
        }
    }
}
