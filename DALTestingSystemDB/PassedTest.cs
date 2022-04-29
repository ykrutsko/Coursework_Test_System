using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALTestingSystemDB
{
    public class PassedTest
    {
        public int Id { get; set; }
        public DateTime TakedDate { get; set; }
        public double PercentGrade { get; set; }
        public bool IsPassed { get; set; }
        public virtual User User { get; set; }
        public virtual Test Test { get; set; }
        public virtual ICollection<PassedTestQuestion> PassedTestQuestions { get; set; }

        public PassedTest()
        {
            PassedTestQuestions = new List<PassedTestQuestion>();
        }
    }
}
