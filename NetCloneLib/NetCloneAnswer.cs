using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCloneLib
{
    [Serializable]
    public class NetCloneAnswer
    {
        public int Id { get; set; }
        public string AnswerText { get; set; }

        public override string ToString()
        {
            return AnswerText;
        }
    }
}
