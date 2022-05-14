using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALTestingSystemDB
{
    public class UserTest
    {
        public int Id { get; set; }
        public virtual User User { get; set; }
        public virtual Test Test { get; set; }
        public int? PointsGrade { get; set; }
        public bool IsPassed { get; set; }
        public DateTime? TakedDate { get; set; }
        public bool IsTaked { get; set; }
        public virtual ICollection<UserAnswer> UserAnswers { get; set; }

        public UserTest()
        {
            UserAnswers = new List<UserAnswer>();
        }

        public override string ToString()
        {
            return "[" + Id + "], User: " + User.ToString() + ", Test: " + Test.ToString();
        }
    }
}
