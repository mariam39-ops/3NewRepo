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
        //answer 8
        //ده معناها بقى اني بجبر الجينارك بقى يبقى ريفرنس تانيب مينفعش يبقي value
        class Cconstrains<T> where T : class
        {
            public T Value;

            public void Add(T c)
            {
                Value =c;
            }
        }
    }
}
