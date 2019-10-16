using System;

namespace L02_ProgrammierenInC__1
{
    class L03
    {
        public static void Main(string[] args)
        {
            taskOne();
        }
        public static void taskOne()
        {
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

        public static void taskTwo()
        {
            int[] ia = { 1, 0, 2, 9, 3, 8, 4, 7, 5, 6, 10 };

            int ergebnis = ia[2] * ia[8] + ia[4];//=13

            Console.WriteLine(ergebnis);
            Console.WriteLine("ia Length = " + ia.Length);
        }

        public static void taskThree()
        {
            double kk = 2.97 * Math.Pow(10, -19);
            double[] da = { 3.1415, 2.7183, kk };
        }

        public static void taskFour()
        {
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

        public static void taskFive()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            /*if(a == b) {

                Console.WriteLine("a und b sind gleich groß");
            }else if(a > b) {

                Console.WriteLine("a ist größer als b");
            } else {

                Console.WriteLine("b ist größer als a");
            }*/

            if (a > 3 && b == 6)
            {

                Console.WriteLine("Du hast gewonnen");
            }
            else
            {

                Console.WriteLine("Leider verloren");
            }
        }

        public static void taskSix()
        {
            int i = 1;

            while (i < 11)
            {

                Console.WriteLine(i);
                i++;
            }
        }

        public static void taskSeven()
        {
            //string i = Console.ReadLine();
            /*switch (i)
            {
            case "1":
                Console.WriteLine("Du hast EINS eingegeben");
                break;
            case "2":
                Console.WriteLine("ZWEI war Deine Wahl");
                break;
            case "3":
                Console.WriteLine("Du tipptest eine DREI");
                break;
            case "4":
                Console.WriteLine("VIER gewinnt");
                break;
            default:
                Console.WriteLine("Die Zahl " + i + " kenne ich nicht");
                break;
            }*/

            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Console.WriteLine("Du hast EINS eingegeben");
                    break;
                case 2:
                    Console.WriteLine("ZWEI war Deine Wahl");
                    break;
                case 3:
                    Console.WriteLine("Du tipptest eine DREI");
                    break;
                case 4:
                    Console.WriteLine("VIER gewinnt");
                    break;
                default:
                    Console.WriteLine("Die Zahl " + i + " kenne ich nicht");
                    break;
            }

            /*if(i == 1) {

                Console.WriteLine("Du hast EINS eingegeben");
            } else if(i == 2) {

                Console.WriteLine("ZWEI war Deine Wahl");
            } else if(i == 3) {

                Console.WriteLine("Du tipptest eine DREI");
            } else if(i == 4) {

                Console.WriteLine("VIER gewinnt");
            } else {

                Console.WriteLine("Die Zahl " + i + " kenne ich nicht");
            }*/
        }

        public static void taskEight()
        {
            string[] someStrings =
            {
                "Hier",
                "sehen",
                "wir",
                "einen",
                "Array",
                "von",
                "Strings"
            };

            for (int i = 0; i < someStrings.Length; i++)
            {
                Console.WriteLine(someStrings[i]);
            }
        }

        public static void taskNine()
        {
            string[] someStrings =
            {
                "Hier",
                "sehen",
                "wir",
                "einen",
                "Array",
                "von",
                "Strings"
            };

            int i = 0;
            do
            {
                Console.WriteLine(someStrings[i]);
                i++;
            }
            while (i < someStrings.Length);
        }

        public static void taskTen()
        {
            string[] someStrings =
            {
                "Hier",
                "sehen",
                "wir",
                "einen",
                "Array",
                "von",
                "Strings"
            };

            int i = 0;
            while (true)
            {
                if (i == someStrings.Length)
                    break;
                Console.WriteLine(someStrings[i]);

                i++;
            }
        }

        public static void taskEleven()
        {
            string[] someStrings =
            {
                "Hier",
                "sehen",
                "wir",
                "einen",
                "Array",
                "von",
                "Strings"
            };

            foreach (string s in someStrings)
            {
                Console.WriteLine(s);
            }
        }
    }
}