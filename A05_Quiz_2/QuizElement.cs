using System;
using System.Collections.Generic;

namespace A05_Quiz2
{
    public class QuizElement
    {
        public string question;
        public bool wasAnswered = false;

        public virtual bool AnswerQuestion()
        {
            return true;
        }
    }
}