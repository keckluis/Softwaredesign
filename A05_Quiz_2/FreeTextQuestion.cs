using System;

namespace A05_Quiz2
{
    class FreeTextQuestion : QuizElement
    {
        public string correctAnswer;

        public override bool AnswerQuestion()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(this.question);
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("> ");
            string userAnswer = Console.ReadLine();
            this.wasAnswered = true;
            return CheckAnswer(userAnswer);
        }

        private bool CheckAnswer(string answer)
        {
            if(answer.Equals(this.correctAnswer))
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
            Console.WriteLine("Enter the question:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(">");
            this.question = Console.ReadLine();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter the correct answer:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(">");
            this.correctAnswer = Console.ReadLine(); 
        }
    }
}