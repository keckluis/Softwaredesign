using System;
using System.Collections.Generic;

namespace L03_Debugging {

    public class TestToString {

        public static void tester() {
            
            //TODO 1
            int[] array = {0, 1, 2, 3, 4, 5};
            Console.WriteLine("Array: " + array);

            List<Person> list = new List<Person>(); 
            list.Add(new Person("Luke", "Skywalker", Convert.ToDateTime("1951/09/25")));
            list.Add(new Person("Han", "Solo", Convert.ToDateTime("1942/07/13")));
            list.Add(new Person("Obi-Wan", "Kenobi", Convert.ToDateTime("1914/04/02")));
            Console.WriteLine("Liste: " + list);

            //works now because of TODO 2
            Console.WriteLine("Klasse: " + new Person("Leia", "Organa", Convert.ToDateTime("1956/10/21")));

            //TODO 2
            Person p = new Person("Darth", "Vader", Convert.ToDateTime("1931/01/17"));

            Console.WriteLine("Person.ToString(): "+ p.ToString());
        }
    }
}