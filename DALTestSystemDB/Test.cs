using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALTestingSystemDB
{
    public class Test
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Info { get; set; }
        public int PassPercent { get; set; }
        public bool IsArchived { get; set; }
        public bool IsDeletable { get; set; }
        public DateTime LoadedDate { get; set; }
        public virtual Folder Folder { get; set; }
        public virtual ICollection<UserTest> UserTests { get; set; }
        public virtual ICollection<Question> Questions { get; set; }

        public Test()
        {
            Questions = new List<Question>();
            UserTests = new List<UserTest>();
        }

        public override string ToString()
        {
            return Title + " [author " + Author + "]";
        }
    }
}
