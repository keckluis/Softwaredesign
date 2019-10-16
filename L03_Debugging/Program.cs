using System;
using static System.Console;

public class SimplePerson
{
    public string FirstName;
    public string LastName;
    public DateTime DateOfBirth;

    public override string ToString()
    {
        return (FirstName + " " + LastName + ", " + DateOfBirth.Year);
    }
}

namespace L03_Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            Person root = Familytree.BuildTree();

            Person found = Familytree.Find(root);

            WriteLine(found.ToString());
        }
    }
}