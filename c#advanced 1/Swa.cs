using System;
using System.Collections.Generic;
using System.Text;

namespace c_advanced_1
{
    internal class Swap
    {
        //answer 4
        //هيا ميثود بقدر نستخدمها مع اكتر من نوع من البايانات بيتحدد النوع فى الruntime;
      public static void Print<T>(T value)
        {
            Console.WriteLine(value);
        }
    }
}
