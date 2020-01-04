using System;
using System.Collections.Generic;
using System.IO;
using System.Data;
using Newtonsoft.Json;

namespace A05_Quiz2
{
    public class QuizElementLoader
    {
        public List<QuizElement> LoadJson(string path)
        {
            List<QuizElement> quizElements = new List<QuizElement>();
            string json;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    json = sr.ReadToEnd();

                    DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(json);

                    DataTable dataTable = dataSet.Tables["QuizElements"];

                    foreach (DataRow row in dataTable.Rows)
                    {
                        if(row["type"].ToString().Equals("MultiChoice"))
                        {
                            MultiChoiceQuestion mc = new MultiChoiceQuestion();
                            mc.question = row["question"].ToString();
                            mc.correctAnswer = row["correctAnswer"].ToString();
                            string wa = row["wrongAnswers"].ToString();
                            string[] splitAnswers = wa.Split(";");
                            List<string> wrongAnswers = new List<string>();
                            foreach(string a in splitAnswers)
                                wrongAnswers.Add(a);
                            mc.wrongAnswers = wrongAnswers;
                            quizElements.Add(mc);
                        }
                        else if(row["type"].ToString().Equals("TrueFalse"))
                        {
                            TrueFalseQuestion tf = new TrueFalseQuestion();
                            tf.question = row["question"].ToString();
                            if(row["isYesCorrect"].ToString().Equals("true"))
                            {
                                tf.isYesCorrect = true;
                            }
                            else if(row["isYesCorrect"].ToString().Equals("false"))
                            {
                                tf.isYesCorrect = false;
                            }
                            quizElements.Add(tf);
                        }
                        else if(row["type"].ToString().Equals("FreeText"))
                        {
                            FreeTextQuestion ft = new FreeTextQuestion();
                            ft.question = row["question"].ToString();
                            ft.correctAnswer = row["correctAnswer"].ToString();
                            quizElements.Add(ft);
                        }
                        else if(row["type"].ToString().Equals("Estimate"))
                        {
                            EstimateQuestion es = new EstimateQuestion();
                            es.question = row["question"].ToString();
                            es.correctAnswer = Int32.Parse(row["correctAnswer"].ToString());
                            es.tolerance = Int32.Parse(row["tolerance"].ToString());
                            quizElements.Add(es);
                        }
                    }
                    return quizElements;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file contains invalid content.");
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}