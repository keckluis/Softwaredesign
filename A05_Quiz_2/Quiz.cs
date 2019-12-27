using System;
using System.Collections.Generic;

namespace A05_Quiz2
{
    class Quiz
    {
        static List<QuizElement> quizElements = new List<QuizElement>();
        static int credits;
        static int questionsAnswered;
        static bool allQuestionsAnswered = false;
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            Console.Clear();
            QuizElementLoader loader = new QuizElementLoader();

            quizElements = loader.LoadJson("QuizElements.json");
            StartScene();
        }

        public static void StartScene()
        { 
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("You answered " + credits + " out of " + questionsAnswered + " quizElements correctly.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            
            int i = 0;
            foreach(QuizElement q in quizElements)
            {
                if(q.wasAnswered)
                    i++;
            }

            if(i == quizElements.Count)
            {
                allQuestionsAnswered = true;
                Console.WriteLine("You have answered all question. You can quit and start new.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("(1. There are no more quizElements to answer)");
            }
            else
            {
                allQuestionsAnswered = false;
                Console.WriteLine("Do you want to answer a question or quit?");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1. Answer a question");
            }
            
            Console.WriteLine("2. Quit");
            Console.Write("> ");
            string userInput = Console.ReadLine();

            if(userInput == "1")
            {
                if(!allQuestionsAnswered)
                    PlayQuiz();
                else
                    StartScene();
            }            
            else if(userInput == "2")
            {
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input. Please try again.");
                StartScene();
            }
        }

        public static void PlayQuiz()
        {
            if(!allQuestionsAnswered)
            {
                int q = rnd.Next(quizElements.Count);

                if(!quizElements[q].wasAnswered)
                {
                    bool correctAnswer = quizElements[q].AnswerQuestion();

                    if(correctAnswer)
                    {
                        credits++;
                        questionsAnswered++;
                        StartScene();
                    }
                    else
                    {
                        questionsAnswered++;
                        StartScene();
                    }
                }
                else
                {
                    PlayQuiz();
                }
            }
        }
    }
}
