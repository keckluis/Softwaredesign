using System;

namespace A05_Quiz2
{
    class EstimateQuestion : QuizElement
    {
        public int correctAnswer;
        public int tolerance;

        public override bool AnswerQuestion()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(this.question + " (Tolerance is " + tolerance + ")");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("> ");
            string userAnswer = Console.ReadLine();
            if(this.validAnswer(userAnswer))
            {
                this.wasAnswered = true;
                return CheckAnswer(userAnswer);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Invalid input. Please try again.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("> ");
                userAnswer = Console.ReadLine();
            }
            return false;
        }

        private bool CheckAnswer(string answer)
        {
            int a = Int32.Parse(answer);
            
            if(a == correctAnswer)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Right answer!");
                return true;
            }
            else if(a > correctAnswer - tolerance - 1 && a < correctAnswer + tolerance + 1)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Close enough! The correct Answer is '" + correctAnswer +"'.");
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

        public bool validAnswer(string userAnswer)
        {
            try
            {
                int i = Int32.Parse(userAnswer);
                return true;
            }
            catch
            {
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

            bool isNumber1 = false;

            while(!isNumber1)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Enter the correct answer:");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(">");
                string userInput = Console.ReadLine();

                if(validAnswer(userInput))
                {
                    isNumber1 = true;
                    this.correctAnswer = Int32.Parse(userInput);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }

            bool isNumber2 = false;

            while(!isNumber2)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Enter the tolerance:");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(">");
                string userInput = Console.ReadLine();

                if(validAnswer(userInput))
                {
                    isNumber2 = true;
                    this.tolerance = Int32.Parse(userInput);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
        }
    }
}