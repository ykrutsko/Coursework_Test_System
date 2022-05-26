using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCloneLib
{
    [Serializable]
    public class CompletedTest
    {
        public int IdUserTest { get; set; }
        public DateTime TakedDate { get; set; }
        public List<NetCloneAnswer> UserAnwersList { get; set; }
    }
}
