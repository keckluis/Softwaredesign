using System;

namespace Softwaredesign
{
    class CompareInt
    {
        public static void compare() {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            
            /*if(a == b) {

                Console.WriteLine("a und b sind gleich groß");
            }else if(a > b) {

                Console.WriteLine("a ist größer als b");
            } else {

                Console.WriteLine("b ist größer als a");
            }*/

            if(a > 3 && b == 6) {

                Console.WriteLine("Du hast gewonnen");
            } else {

                Console.WriteLine("Leider verloren");
            }
        }
    }
}