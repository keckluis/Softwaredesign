using System;
using System.IO;
using System.Text.Json;

namespace L07_DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = new string[10];

            for(int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = i.ToString();
            }

            var en = stringArray.GetEnumerator();

            for(int j = 0; j < stringArray.Length; j++)
            {
                en.MoveNext();
                Console.WriteLine(en.Current);
            }
        }
    }
}
