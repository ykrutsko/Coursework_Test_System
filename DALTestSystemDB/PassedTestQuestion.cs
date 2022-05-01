using System.Collections.Generic;

namespace DALTestingSystemDB
{
    public class PassedTestQuestion
    {
        public int Id { get; set; }
        public int GotedPoints { get; set; }
        public virtual Question Question { get; set; }
        public virtual PassedTest PassedTest { get; set; }
        public virtual ICollection<PassedTestAnswer> PassedTestAnswers { get; set; }

        public PassedTestQuestion()
        {
            PassedTestAnswers = new List<PassedTestAnswer>();
        }
    }
}