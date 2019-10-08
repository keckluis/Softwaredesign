using System;

namespace Softwaredesign
{
    class SwitchCase
    {
        public static void yourNumber() {

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
            /*switch (i)
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
            }*/

            if(i == 1) {

                Console.WriteLine("Du hast EINS eingegeben");
            } else if(i == 2) {

                Console.WriteLine("ZWEI war Deine Wahl");
            } else if(i == 3) {

                Console.WriteLine("Du tipptest eine DREI");
            } else if(i == 4) {

                Console.WriteLine("VIER gewinnt");
            } else {

                Console.WriteLine("Die Zahl " + i + " kenne ich nicht");
            }
        }
    }
}