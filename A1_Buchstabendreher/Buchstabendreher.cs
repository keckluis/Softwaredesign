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

        static string reverseLetters(string input) {
            
            string output = "";

            string[] words = input.Split(" ");

            foreach(string word in words) {

                string temp = "";

                foreach(char ch in word.ToCharArray()) {
                    
                    temp = ch + temp;
                }
                output = temp + " " + output;
            }
            return output;
        }

        static string reverseWords(string input) {

            string output = "";

            string[] words = input.Split(" ");

            for(int i = words.Length-1; i >= 0; i--) {

                output += words[i] + " ";
            }
            return output;
        }

        static string reverseSentence(string input) {

            string output = "";

            string[] words = input.Split(" ");

            foreach(string word in words) {

                string temp = "";

                foreach(char ch in word.ToCharArray()) {
                    
                    temp = ch + temp;
                }
                output += temp + " ";
            }
            return output;
        }
    }
}
