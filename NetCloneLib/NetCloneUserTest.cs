using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCloneLib
{
    [Serializable]
    public class NetCloneUserTest
    {
        public int Id { get; set; }
        public NetCloneUser User { get; set; }
        public NetCloneTest Test { get; set; }
        public bool IsTaked { get; set; }
        public int PointsGrade { get; set; }
        public bool IsPassed { get; set; }
        public DateTime? TakedDate { get; set; }
    }
}
