using System.Collections.Generic;

namespace DALTestingSystemDB
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public string Img { get; set; }
        public int Points { get; set; }
        public virtual Test Test { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }

        public Question()
        {
            Answers = new List<Answer>();
        }

        public override string ToString()
        {
            return QuestionText;
        }
    }
}