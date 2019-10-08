using System;

namespace Softwaredesign
{
    class DoWhileAndBreak
    {
        public static void usingFor() {

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

        public static void usingDoWhile()
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

            /*int i = 0;
            do ( )
            {
                Console.WriteLine(someStrings[i]);
                i++;
            }
            while (i < someStrings.Length);*/
        }
        
        public static void usingBreak()
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

        public static void usingForEach()
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