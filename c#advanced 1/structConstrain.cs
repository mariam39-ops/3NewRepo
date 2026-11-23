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
        }//answer 11
        // يعني احنا بنشترط علي الجينارك كلاس يكون وارث من كلاس معيه يعني اي كلاس هنحطه مكان الt لازم يكون ورات من الكلاس دي
        class Human
        {
            public string Name;
        }
        class MClass<T> where T : Human
        {
            public void Print(T obj)
            {
                Console.WriteLine(obj.Name);
            }
        }
        class Student : Human
        {
        }
        //answer 12
        //ايوه نقدر نحط اكتر من شرط مثلا انها تمون وراثه من كلاس معين 
        // او انها تعلمل impelment ل interface معين
        //او انها تعمل باراميتر ليس كونستراتور

        class MyClass<T> where T : Person, IPrintable, new()
        {
            public void Display(T obj)
            {
                obj.Print();
            }
        }
    }
    //q13 
    //بترجع القيمه الافتراضيه  لنوع البيانات الوجوده فى الt يعني مثلا لوهيا int ترجع صفر
    class DefaltClass<T>
    {
        public T GetDefault()
        {
            return default(T);
        }
    }
    //answer 14
    class SafeList<T>
    {
        T[] items = new T[5];

        public T Get(int index)
        {
            if (index < items.Length && index >= 0)
            {
                return items[index];
            }

            return default(T);
        }
    }

}
