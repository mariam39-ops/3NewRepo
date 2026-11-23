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
        }// answer 9
        // ده معناه اني لازم اعمل كونستراكتور براميتر ليس  علشان اعرف اعمل منه اوبجيكت باستخدام الكيورد new
        class Class<T> where T : new()
        {
            public T CreateNewObject()
            {
                return new T();
            }
        }
        //answer 10 
        // ده معناه اننا بنشترط على اي جينارك كلاس  مطبق الinterface اي كلاس تاني  هنستخدمها مكان الT لازم تكون عامل امبيلمنت لل انترفيس
        class Intercon<T> where T : IPrintable
        {
            public void Display(T obj)
            {
                obj.Print();
            }
        }
        class Person : IPrintable
        {
            public void Print()
            {
                Console.WriteLine("this person");
            }
        }
    }
}
