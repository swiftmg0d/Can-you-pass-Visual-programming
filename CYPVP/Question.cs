using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CYPVP
{
    public class Question
    {
        public String Text { get; set; }
        public String CorrectAnswer { get; set; }
        public bool IsItAnswered { get; set; }

        public Question(string text, string correctAnswer)
        {
            Text = text;
            CorrectAnswer = correctAnswer;
            IsItAnswered = false;
        }
    }
}
