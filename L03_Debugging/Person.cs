using System;
using static System.Console;

namespace L03_Debugging
{

    public class Person
    {

        public string FirstName;
        public string LastName;
        public DateTime DateOfBirth;
        public DateTime DateOfDeath;

        public Person Mom; //references 2 "Person" objects 'Mom' and 'Dad'
        public Person Dad;

        public override string ToString()
        {

            if (DateOfDeath.Year == 1)
            {
                return (FirstName + " " + LastName + ", " + DateOfBirth.Year + "-*");
            }
            else
            {

                return (FirstName + " " + LastName + ", " + DateOfBirth.Year + "-" + DateOfDeath.Year);
            }
        }
    }

    public class Familytree
    {
        public static Person Find(Person person)
        {

            Person ret = null;

            if (person.LastName == "ElGreco")
                return person;

            if (person.Mom != null)
                ret = Find(person.Mom);

            if (ret != null)
                return ret;

            if (person.Dad != null)
                ret = Find(person.Dad);

            if (ret != null)
                return ret;

            return null;
        }

        public static Person BuildTree()
        {

            return
                new Person
                {
                    FirstName = "Willi",
                    LastName = "Cambridge",
                    DateOfBirth = new DateTime(1982, 07, 21),
                    Mom = new Person
                    {
                        FirstName = "Diana",
                        LastName = "Spencer",
                        DateOfBirth = new DateTime(1961, 07, 01),
                        Mom = new Person
                        {
                            FirstName = "Franzi",
                            LastName = "Roche",
                            DateOfBirth = new DateTime(1936, 01, 20),
                            Mom = new Person { FirstName = "Ruth", LastName = "Gill", DateOfBirth = new DateTime(1908, 06, 07), DateOfDeath = new DateTime(1998, 07, 01) },
                            Dad = new Person { FirstName = "Moritz", LastName = "Roche", DateOfBirth = new DateTime(1885, 07, 08), DateOfDeath = new DateTime(1950, 12, 23) }
                        },
                        Dad = new Person
                        {
                            FirstName = "Eddie",
                            LastName = "Spencer",
                            DateOfBirth = new DateTime(1924, 01, 24),
                            DateOfDeath = new DateTime(2010, 04, 19),
                            Mom = new Person { FirstName = "Cynthia", LastName = "Hamilton", DateOfBirth = new DateTime(1897, 08, 16), DateOfDeath = new DateTime(1988, 02, 28), },
                            Dad = new Person { FirstName = "Albert", LastName = "Spencer", DateOfBirth = new DateTime(1892, 05, 23), DateOfDeath = new DateTime(1977, 06, 22), }
                        },
                    },
                    Dad = new Person
                    {
                        FirstName = "Charlie",
                        LastName = "Wales",
                        DateOfBirth = new DateTime(1948, 11, 14),
                        Mom = new Person
                        {
                            FirstName = "Else",
                            LastName = "Windsor",
                            DateOfBirth = new DateTime(1926, 04, 21),
                            DateOfDeath = new DateTime(2000, 10, 05),
                            Mom = new Person { FirstName = "Lisbeth", LastName = "Bowes-Lyon", DateOfBirth = new DateTime(1900, 08, 04), DateOfDeath = new DateTime(2000, 01, 01), },
                            Dad = new Person { FirstName = "Schorsch-Albert", LastName = "York", DateOfBirth = new DateTime(1895, 12, 14), DateOfDeath = new DateTime(1985, 03, 11), }
                        },
                        Dad = new Person
                        {
                            FirstName = "Philip",
                            LastName = "Battenberg",
                            DateOfBirth = new DateTime(1921, 06, 10),
                            DateOfDeath = new DateTime(2015, 08, 13),
                            Mom = new Person { FirstName = "Alice", LastName = "Battenberg", DateOfBirth = new DateTime(1885, 02, 25), DateOfDeath = new DateTime(1974, 05, 05), },
                            Dad = new Person { FirstName = "Andi", LastName = "ElGreco", DateOfBirth = new DateTime(1882, 02, 01), DateOfDeath = new DateTime(1976, 09, 30), },
                        },
                    },
                };
        }
    }
}
