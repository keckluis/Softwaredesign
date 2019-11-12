using System;
using System.Collections.Generic;

namespace A04_Quiz
{
    class Quiz
    {
        public static List<QuizElement> questions = new List<QuizElement>();
        
        public static int credits;
        public static int questionsAnswered;
        public bool answer;
        public static bool answerAgain = false;
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            QuizElement Q1 = new QuizElement();
            Q1.Question = "Who was the director of the movie 'Inception'(2010)?";
            Q1.CorrectAnswer = "Cristopher Nolan";
            Q1.Answers.Add("Steven Spielberg");
            Q1.Answers.Add("James Cameron");
            Q1.Answers.Add("Michael Bay");
            questions.Add(Q1);

            QuizElement Q2 = new QuizElement();
            Q2.Question = "";
            Q2.CorrectAnswer = "";
            Q2.Answers.Add("");
            Q2.Answers.Add("");
            Q2.Answers.Add("");
            questions.Add(Q2);

            QuizElement Q3 = new QuizElement();
            Q3.Question = "";
            Q3.CorrectAnswer = "";
            Q3.Answers.Add("");
            Q3.Answers.Add("");
            Q3.Answers.Add("");
            questions.Add(Q3);

            StartScene();
        }

        public static void StartScene()
        {
            bool quiz = false;
            bool addQuestion = false;
            answerAgain = false;
            string selection = "";

            Console.WriteLine("You answered " + credits + " out of " + questionsAnswered + " 1uestions correctly.");

            Console.WriteLine("Do you want to answer a question or add a new quiz element?");
            Console.WriteLine("1. Answer a question");
            Console.WriteLine("2. Add new quiz element");
            string userInput = Console.ReadLine();

            if(userInput == "1")
            {
                PlayQuiz();
            }
            else if(userInput == "2")
            {

            }
            else
            {
                Console.WriteLine("Unknown input. Please try again.");
                StartScene();
            }
        }

        public static void PlayQuiz()
        {
            int q = rnd.Next(questions.Count);

            QuizElement question = questions[q];

            Console.WriteLine(question.Question);

            List<string> answers = question.Answers;
            answers.Add(question.CorrectAnswer);

            var shuffled = answers.OrderBy(x => Guid.NewGuid()).ToList();
        }

        public void CheckAnswer(string input)
        {

        }

        public void AddUserQuestion()
        {

        }
    }
}
