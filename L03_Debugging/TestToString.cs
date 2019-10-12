using System;
using System.Collections.Generic;

namespace L03_Debugging {

    public class TestToString {

        public static void tester() {

            //TODO 1
            int[] a = { 0, 1, 2, 3, 4, 5 };
            Console.WriteLine("Array: " + a);

            List<OldPerson> list = new List<OldPerson>(); 
            list.Add(new OldPerson("Luke", "Skywalker", 19));
            list.Add(new OldPerson("Han", "Solo", 32));
            list.Add(new OldPerson("Obi-Wan", "Kenobi", 57));
            Console.WriteLine("Liste: " + list);

            //works now because of TODO 2
            Console.WriteLine("Klasse: " + new OldPerson("Leia", "Organa", 19));

            //TODO 2
            OldPerson p0 = new OldPerson("Luke", "Skywalker", 19);
            OldPerson p1 = new OldPerson("Han", "Solo", 32);
            OldPerson p2 = new OldPerson("Obi-Wan", "Kenobi", 57);
            OldPerson p3 = new OldPerson("Leia", "Organa", 19);
            OldPerson p4 = new OldPerson("Darth", "Vader", 42);

            OldPerson[] persons = {p0, p1, p2, p3, p4};

            foreach(OldPerson p in persons) {

                if(p.Age > 20) {

                    Console.WriteLine(p.ToString());
                }
            }
        }
    }

    public class OldPerson {

        public string FirstName;
        public string LastName;
        public int Age;

        public Person Mom;
        public Person Dad;

        public OldPerson(string f, string l, int a) {

            this.FirstName = f;
            this.LastName = l;
            this.Age = a;
        }

        public override string ToString() {

            return(FirstName + " " + LastName + ", "+ Age);
        }
    }
}