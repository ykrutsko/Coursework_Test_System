using System.Collections.Generic;

namespace DALTestingSystemDB
{
    public class Folder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDeletable { get; set; }
        public bool IsEditable { get; set; }
        public virtual ICollection<Test> Tests { get; set; }

        public Folder()
        {
            Tests = new List<Test>();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}