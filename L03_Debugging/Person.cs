using System;

namespace L03_Debugging {

    public class Person {

        public string FirstName;
        public string LastName;
        public DateTime DateOfBirth;

        public Person(string f, string l, DateTime a) {

            this.FirstName = f;
            this.LastName = l;
            this.DateOfBirth = a;
        }

        public override string ToString() {

            return(FirstName + " " + LastName + ", "+ DateOfBirth.ToShortDateString());
        }
    }
}