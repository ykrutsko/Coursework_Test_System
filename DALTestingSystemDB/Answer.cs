namespace DALTestingSystemDB
{
    public class Answer
    {
        public int Id { get; set; }
        public string AnswerText { get; set; }
        public bool IsRight { get; set; }
        public virtual Question Question { get; set; }

        public override string ToString()
        {
            return AnswerText;
        }
    }
}