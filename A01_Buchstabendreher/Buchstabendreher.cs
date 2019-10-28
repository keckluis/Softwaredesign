using System;

namespace A01_Buchstabendreher
{
    class Buchstabendreher
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte einen kleinen Satz eingeben");
            Console.Write("> ");
            var text = Console.ReadLine();
            string letters = reverseLetters(text);
            string words = reverseWords(text);
            string sentence = reverseSentence(text);
            Console.WriteLine(sentence + "\n" + words + "\n" + letters);
        }

        static string reverseLetters(string input)
        {
            char[] temp = input.ToCharArray();
            Array.Reverse(temp);

            return new String(temp);
        }

        static string reverseWords(string input)
        {
            string[] temp = input.Split(" ");
            Array.Reverse(temp);

            return string.Join(" ", temp);
        }

        static string reverseSentence(string input)
        {
            return reverseWords(reverseLetters(input));
        }
    }
}
