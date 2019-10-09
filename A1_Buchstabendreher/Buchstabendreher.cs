using System;

namespace A1_Buchstabendreher {
    
    class Buchstabendreher {
        static void Main(string[] args) {

            Console.WriteLine("Bitte einen kleinen Satz eingeben");
            Console.Write("> ");
            var text = Console.ReadLine();
            string letters = reverseLetters(text);
            string words = reverseWords(text);
            string sentence = reverseSentence(text);
            Console.WriteLine(sentence + "\n" + words + "\n" + letters);
        }

        static string reverseLetters(string s) {

            return s;
        }

        static string reverseWords(string s) {

            return s;
        }

        static string reverseSentence(string s) {

            return s;
        }
    }
}
