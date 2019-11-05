using System;

namespace L05_ProgrammierenInC__2
{
    class Person
    {
        //if "public" is removed, Tester.cs can no longer access Person.cs's variables
        public string Name;
        public int Age;

        static void Main(string[] args)
        {
            Person myself = new Person { Name = "Keck", Age = 21 };//TODO 1

            Person[] persons1 = new Person[5];//TODO 2
            persons1[0] = new Person { Name = "Meyer", Age = 33 };
            persons1[1] = new Employee { Name = "Schmidt", Age = 58 };
            persons1[2] = new Person { Name = "Fischer", Age = 41 };
            persons1[3] = new Employee { Name = "Weber", Age = 76 };
            persons1[4] = new Person { Name = "Zimmermann", Age = 56 };

            Person[] persons2 = new Person[4];//TODO 3
            persons2[0] = new Female { Name = "Meyer", Age = 33 };
            persons2[1] = new Male { Name = "Schmidt", Age = 58 };
            persons2[2] = new Female { Name = "Fischer", Age = 41 };
            persons2[3] = new Male { Name = "Weber", Age = 76 };
            foreach (Person p in persons2)
            {
                Console.WriteLine(p.GetTitleAdress());
            }

            MyContainer<Person> persons3 = new MyContainer<Person>();
            persons3.Add(new Female { Name = "Meyer", Age = 33 });
            persons3.Add(new Male { Name = "Schmidt", Age = 58 });
            persons3.Add(new Female { Name = "Fischer", Age = 41 });
            persons3.Add(new Male { Name = "Weber", Age = 76 });
        }

        public virtual string GetTitleAdress()
        {
            if (Age < 18)
                return "Hey " + Name;
            else
                return "Sehr geehrte(r) " + Name;
        }
    }

    class Employee : Person
    {
        public int idNumber;
    }

    class Female : Person
    {
        public override string GetTitleAdress()
        {
            return "Sehr geehrte Frau " + Name;
        }
    }
    class Male : Person
    {
        public override string GetTitleAdress()
        {
            return "Sehr geehrter Herr " + Name;
        }
    }

    public class MyContainer<T>
    {
        private T[] _theObjects;
        private int _n;

        public MyContainer()
        {
            _theObjects = new T[2];
            _n = 0;
        }

        public void Add(T o)
        {
            // If necessary, grow the array
            if (_n == _theObjects.Length)
            {
                T[] oldArray = _theObjects;
                _theObjects = new T[2 * oldArray.Length];
                Array.Copy(oldArray, _theObjects, _n);
            }

            _theObjects[_n] = o;
            _n++;
        }

        public T GetAt(int i)
        {
            return _theObjects[i];
        }

        public int Count
        {
            get { return _n; }
        }
    }
}
