using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib
{
    [Serializable]
    public class Question : IEquatable<Question>
    {
        public string QuestionText { get; set; }
        public int Points { get; set; }     // ваговий коефіцієнт
        public List<Answer> Answers { get; set; }

        public Question()
        {
            QuestionText = String.Empty;
            Points = 0;
            Answers = new List<Answer>();
        }

        public Question(string questionText, int points, List<Answer> answers)
        {
            QuestionText = questionText;
            Points = points;
            Answers = answers;
        }

        public bool Equals(Question other)
        {
            return other is Question &&
                this.QuestionText == other.QuestionText &&
                this.Points == other.Points &&
                this.Answers.SequenceEqual(other.Answers);
        }
    }
}
