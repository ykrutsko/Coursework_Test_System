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
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<PassedTest> PassedTests { get; set; }

        public Test()
        {
            Users = new List<User>();
            Questions = new List<Question>();
            PassedTests = new List<PassedTest>();
        }

        public override string ToString()
        {
            return Title + " [author " + Author + "]";
        }
    }
}
