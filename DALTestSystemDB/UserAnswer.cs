namespace DALTestingSystemDB
{
    public class UserAnswer
    {
        public int Id { get; set; }
        public bool IsChecked { get; set; }
        public virtual Answer Answer { get; set; }
        public virtual UserTest UserTest { get; set; }
    }
}