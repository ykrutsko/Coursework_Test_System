using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib
{
    [Serializable]
    public class Question
    {
        public string QuestionText { get; set; }
        public int Points { get; set; }     // ваговий коефіцієнт
        public byte[] Image { get; set; }
        public List<Answer> Answers { get; set; }

        public Question()
        {
            QuestionText = String.Empty;
            Points = 0;
            Answers = new List<Answer>();
        }

        public Question(string questionText, int points, byte[] image, List<Answer> answers)
        {
            QuestionText = questionText;
            Points = points;
            Image = image;
            Answers = answers;
        }
    }
}
