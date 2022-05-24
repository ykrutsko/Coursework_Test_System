using System.Collections.Generic;
using System.Windows.Forms;

namespace TestClient
{
    public class VisualQuestion
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public string Img { get; set; }
        public int Points { get; set; }
        public int CountRight { get; set; }
        public GroupBox GroupBox { get; set; }
        public List<VisualAnswer> VisualAnswersList { get; set; }

        public VisualQuestion()
        {
            VisualAnswersList = new List<VisualAnswer>();
        }
    }
}