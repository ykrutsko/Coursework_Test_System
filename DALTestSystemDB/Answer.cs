using System;
using System.Collections.Generic;

namespace DALTestingSystemDB
{
    [Serializable]
    public class Answer
    {
        public int Id { get; set; }
        public string AnswerText { get; set; }
        [field: NonSerialized] public bool IsRight { get; set; }
        public virtual Question Question { get; set; }
        public virtual ICollection<UserAnswer> UserAnswers { get; set; }

        public Answer()
        {
            UserAnswers = new List<UserAnswer>();
        }

        public override string ToString()
        {
            return AnswerText;
        }
    }
}