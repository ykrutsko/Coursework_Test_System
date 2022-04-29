using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALTestingSystemDB
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public byte[] Password { get; set; }
        public string Description { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime RegisterDate { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<Test> Tests { get; set; }

        public User()
        {
            Groups = new List<Group>();
            Tests = new List<Test>();
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " [" + Login + (IsAdmin ? ", Admin" : String.Empty) + "]";
        }


    }
}
