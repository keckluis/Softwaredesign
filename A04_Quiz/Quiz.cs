using System;
using System.Collections.Generic;

namespace A04_Quiz
{
    class Quiz
    {
        static List<QuizElement> questions = new List<QuizElement>();
        static int credits;
        static int questionsAnswered;
        static bool allQuestionsAnswered = false;
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            Console.Clear();

            QuizElement Q1 = new QuizElement();
            Q1.Question = "Who was the director of the movie 'Inception'(2010)?";
            Q1.CorrectAnswer = "Cristopher Nolan";
            Q1.Answers.Add("Steven Spielberg");
            Q1.Answers.Add("James Cameron");
            Q1.Answers.Add("Michael Bay");
            questions.Add(Q1);

            QuizElement Q2 = new QuizElement();
            Q2.Question = "What language is the movie 'Pan's Labyrinth'(2006) in?";
            Q2.CorrectAnswer = "Spanish";
            Q2.Answers.Add("Portuguese");
            Q2.Answers.Add("English");
            Q2.Answers.Add("French");
            questions.Add(Q2);

            QuizElement Q3 = new QuizElement();
            Q3.Question = "For which of these films did Quentin Tarantino win a Best Writing/Screenplay Oscar?";
            Q3.CorrectAnswer = "Pulp Fiction(1994)";
            Q3.Answers.Add("Reservoir Dogs(1992)");
            Q3.Answers.Add("The Hateful Eight(2015)");
            Q3.Answers.Add("Inglourious Basterds(2009)");
            questions.Add(Q3);

            StartScene();
        }

        public static void StartScene()
        {
            if(!allQuestionsAnswered)
            {
                Console.WriteLine("You answered " + credits + " out of " + questionsAnswered + " questions correctly.");
                
                int i = 0;
                foreach(QuizElement q in questions)
                {
                    if(q.wasAnswered)
                        i++;
                }

                if(i == questions.Count)
                {
                    allQuestionsAnswered = true;
                    Console.WriteLine("You have answered all question. You can add new quiz elements or quit and start new.");
                    Console.WriteLine("(1. There are no more questions to answer)");
                }
                else
                {
                    allQuestionsAnswered = false;
                    Console.WriteLine("Do you want to answer a question or add a new quiz element?");
                    Console.WriteLine("1. Answer a question");
                }
                
                Console.WriteLine("2. Add new quiz element");
                Console.WriteLine("3. Quit");
                string userInput = Console.ReadLine();

                if(userInput == "1" && !allQuestionsAnswered)
                {
                    PlayQuiz();
                }
                else if(userInput == "2")
                {
                    AddUserQuestion();
                }
                else if(userInput == "3")
                {
                return;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input. Please try again.");
                    StartScene();
                }
            }
            else
            {
                return;
            }
        }

        public static void PlayQuiz()
        {
            Console.Clear();

            int q = rnd.Next(questions.Count);

            QuizElement question = null;

            if(!questions[q].wasAnswered)
            {
                question = questions[q];
            }
            else
            {
                PlayQuiz();
            }

            question.wasAnswered = true;

            List<string> answers = new List<string>();
            answers = question.Answers;
            answers.Add(question.CorrectAnswer);

            List<string> shuffledAnswers = new List<string>();

            while(answers.Count != 0)
            {
                int r = rnd.Next(answers.Count);
                shuffledAnswers.Add(answers[r]);
                answers.RemoveAt(r);
            }

            Console.WriteLine(question.Question);

            int c = 1;
            foreach(string a in shuffledAnswers)
            {
                Console.WriteLine(c + ". " + a);
                c++;
            }
            
            string userAnswer = Console.ReadLine();
            bool validAnswer = false;

            while(!validAnswer)
            {
                validAnswer = CheckIfAnswerValid(shuffledAnswers.Count, userAnswer);

                if(!validAnswer)
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    userAnswer = Console.ReadLine();
                }
            }

            if(CheckAnswer(userAnswer, shuffledAnswers, question))
            {
                Console.Clear();
                Console.WriteLine("Right answer!");
                credits++;
                questionsAnswered++;
                StartScene();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wrong answer!");
                questionsAnswered++;
                StartScene();
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

        public static bool CheckAnswer(string input, List<string> shuffledAnswers, QuizElement question)
        {
            int i = Int32.Parse(input) - 1;

            if(shuffledAnswers[i] == question.CorrectAnswer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void AddUserQuestion()
        {
            QuizElement newElement = new QuizElement();

            Console.WriteLine("Please type your question:");
            newElement.Question = Console.ReadLine();

            Console.WriteLine("Please type the correct answer:");
            newElement.CorrectAnswer = Console.ReadLine();

            Console.WriteLine("Please type a wrong answer:");
            newElement.Answers.Add(Console.ReadLine());

            bool finished = false;

            while(newElement.Answers.Count < 6 && !finished) 
            {
                Console.WriteLine("Type another wrong answer or press Enter to save your quiz element:");
                string input = Console.ReadLine();
                if(input == "")
                {
                    questions.Add(newElement);
                    finished = true;
                }
                else
                {
                    
                    newElement.Answers.Add(input);
                }
            }

            Console.WriteLine("Your quiz element was added to the question pool.");
            StartScene();
        }
    }
}
