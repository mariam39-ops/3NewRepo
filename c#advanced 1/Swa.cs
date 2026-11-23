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
     //answer 5
            static T FindMax<T>(T x, T y) where T : IComparable<T>
            {
                if (x.CompareTo(y) > 0)
                {
                    return x;
                }
                else
                {
                    return y;
                }
            }
        }
    }


