using System;

namespace Softwaredesign
{
    class Csharp
    {
        public static void taskOne() {

            var i = 42;
            var pi = 3.1415;
            var salute = "Hello, World";

            Console.WriteLine(i);
            Console.WriteLine(pi);
            Console.WriteLine(salute);

            //var variable0 = 0;//int
            //var variable1 = 0.0;//double
            //var variable2 = 0.0f;//float
        }

        public static void taskTwo() {

            int[] ia = {1, 0, 2, 9, 3, 8, 4, 7, 5, 6, 10};

            int ergebnis = ia[2] * ia[8] + ia[4];//=13

            Console.WriteLine(ergebnis);
            Console.WriteLine("ia Length = " + ia.Length);
        }

        public static void taskThree() {

            double kk = 2.97*Math.Pow(10, -19);
            double[] da = {3.1415, 2.7183, kk};
        }

        public static void taskFour() {

            string a = "eins";
            string b = "zwei";
            string c = "eins";
            bool a_eq_b = (a == b);
            bool a_eq_c = (a == c);
            string meinString = "Dies ist ein String";
            char zeichen = meinString[5];

            Console.WriteLine(meinString);
            Console.WriteLine(c);
            Console.WriteLine(a_eq_b);
            Console.WriteLine(a_eq_c);
            Console.WriteLine(zeichen);
        }
    }
}