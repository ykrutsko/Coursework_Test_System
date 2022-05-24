using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCloneLib
{
    [Serializable]
    public class NetCloneTest
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Info { get; set; }
        public int PassPercent { get; set; }
        public List<NetCloneQuestion> Questions { get; set; }

        public override string ToString()
        {
            return "[" + Id + "] " + Title + " (" + Author + ")";
        }
    }
}
