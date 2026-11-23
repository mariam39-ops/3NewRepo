using System;
using System.Collections.Generic;
using System.Text;

namespace c_advanced_1
{
    internal class structConstrain
    {
        ///answer 7 
        // ده معناه اني بجبر الجينارك انه يبقي value type ميقبلش ابدا يبقي ريفرنس تانيب
        class SC<T> where T : struct
        {
            public T Value;

            public void Add(T n)
            {
                Value = n;
            }
        }
    }
}
