using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALTestingSystemDB
{
    public class TestingSystemContext : DbContext
    {
        public TestingSystemContext(string conStr) : base(conStr)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Folder> Folders { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<PassedTest> PassedTests { get; set; }
        public DbSet<PassedTestQuestion> PassedTestQuestions { get; set; }
        public DbSet<PassedTestAnswer> PassedTestAnswers{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasMany(x => x.Groups).WithMany(y => y.Users);
        }

    }
}
