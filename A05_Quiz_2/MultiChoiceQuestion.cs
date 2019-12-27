using System;
using System.Collections.Generic;

namespace A05_Quiz2
{
    class MultiChoiceQuestion : QuizElement
    {
        public string correctAnswer;
        public List<string> wrongAnswers;
        static Random rnd = new Random();

        public override bool AnswerQuestion()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(this.question);
            Console.ForegroundColor = ConsoleColor.White;

            List<string> answers = new List<string>();

            foreach(string a in this.wrongAnswers)    
                answers.Add(a);

            answers.Add(this.correctAnswer);

            List<string> shuffledAnswers = new List<string>();

            while(answers.Count != 0)
            {
                int r = rnd.Next(answers.Count);
                shuffledAnswers.Add(answers[r]);
                answers.RemoveAt(r);
            }

            int c = 1;
            foreach(string a in shuffledAnswers)
            {
                Console.WriteLine(c + ". " + a);
                c++;
            }

            Console.Write("> ");
            string userAnswer = Console.ReadLine();
            bool validAnswer = false;

            while(!validAnswer)
            {
                validAnswer = CheckIfAnswerValid(shuffledAnswers.Count, userAnswer);

                if(!validAnswer)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Invalid input. Please try again.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("> ");
                    userAnswer = Console.ReadLine();
                }
            }
            this.wasAnswered = true;
            return this.CheckAnswer(userAnswer, shuffledAnswers);
        }

        private bool CheckAnswer(string answer, List<string> shuffledAnswers)
        {
            int i = Int32.Parse(answer) - 1;

            if(shuffledAnswers[i].Equals(this.correctAnswer))
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

        public static bool CheckIfAnswerValid(int answerCount, string userAnswer)
        {
            try
            {
                int i = Int32.Parse(userAnswer);
                if(i > 0 && i < answerCount + 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            } 
        }
    }
}