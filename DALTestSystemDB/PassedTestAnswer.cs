namespace DALTestingSystemDB
{
    public class PassedTestAnswer
    {
        public int Id { get; set; }
        public bool IsChecked { get; set; }
        public virtual Answer Answer { get; set; }
        public virtual PassedTestQuestion PassedTestQuestion { get; set; }
    }
}