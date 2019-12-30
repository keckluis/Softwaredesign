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
            MainMenu();
        }

        public static void MainMenu()
        { 
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("You answered " + credits + " out of " + questionsAnswered + " Questions correctly.");
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
                Console.WriteLine("(1. There are no more questions to answer)");
            }
            else
            {
                allQuestionsAnswered = false;
                Console.WriteLine("Do you want to answer a question or add a new quiz element?");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1. Answer a question");
            }

            Console.WriteLine("2. Add new quiz element");
            Console.WriteLine("3. Quit");
            Console.Write("> ");
            string userInput = Console.ReadLine();

            if(userInput == "1")
            {
                if(!allQuestionsAnswered)
                    PlayQuiz();
                else
                    MainMenu();
            }  
            else if(userInput == "2")
            {
                AddNewQuizElement();
            }       
            else if(userInput == "3")
            {
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input. Please try again.");
                MainMenu();
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
                        credits++;

                    questionsAnswered++;
                    MainMenu();
                }
                else
                {
                    PlayQuiz();
                }
            }
        }

        public static void AddNewQuizElement()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Choose the type of quiz element.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Multiple Choice");
            Console.WriteLine("2. True or False");
            Console.WriteLine("3. Free Text Answer");
            Console.WriteLine("4. Estimate");

            Console.Write("> ");
            string userInput = Console.ReadLine();

            if(userInput == "1")
            {
                MultiChoiceQuestion mc = new MultiChoiceQuestion();
                mc.AddNew();

                quizElements.Add(mc);
            }  
            else if(userInput == "2")
            {
                TrueFalseQuestion tf = new TrueFalseQuestion();
                tf.AddNew();

                quizElements.Add(tf); 
            }       
            else if(userInput == "3")
            {
                FreeTextQuestion ft = new FreeTextQuestion();
                ft.AddNew();

                quizElements.Add(ft);
            }
            else if(userInput == "4")
            {
                EstimateQuestion es = new EstimateQuestion();
                es.AddNew();

                quizElements.Add(es);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input. Please try again.");
                AddNewQuizElement();
            }

            MainMenu();
        }
    }
}
