using System;

namespace A05_Quiz2
{
    class TrueFalseQuestion : QuizElement
    {
        public bool isYesCorrect;

        public override bool AnswerQuestion()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(this.question);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. true");
            Console.WriteLine("2. false");

            Console.Write("> ");
            string userAnswer = Console.ReadLine();
            if(userAnswer == "1")
            {
                this.wasAnswered = true;
                return CheckAnswer(true);
            }
            else if(userAnswer == "2")
            {
                this.wasAnswered = true;
                return CheckAnswer(false);
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
                this.AnswerQuestion();
            }
            return false;
        }

        private bool CheckAnswer(bool answer)
        {
            if(answer == isYesCorrect)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Right answer!");
                return true;
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong answer!");
                return false;
            }
        }

        public void AddNew()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter the statement:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(">");
            this.question = Console.ReadLine();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Is the statement true or false?");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. true");
            Console.WriteLine("2. false");
            Console.Write(">");
            
            string userInput = Console.ReadLine();

            if(userInput == "1")
            {
               this.isYesCorrect = true;
            }  
            else if(userInput == "2")
            {
                this.isYesCorrect = false;
            } 
        }
    }
}