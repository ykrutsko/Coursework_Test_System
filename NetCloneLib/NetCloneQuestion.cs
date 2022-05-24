using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCloneLib
{
    [Serializable]
    public class NetCloneQuestion
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public string Img { get; set; }
        public int Points { get; set; }
        public int CountRight { get; set; }
        public List<NetCloneAnswer> Answers { get; set; }

        public NetCloneQuestion()
        {
            Answers = new List<NetCloneAnswer>();
        }
        public override string ToString()
        {
            return QuestionText;
        }
    }
}
