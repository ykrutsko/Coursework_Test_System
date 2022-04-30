using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALTestingSystemDB
{
    public class TestSystemContext : DbContext
    {
        public TestSystemContext() : base()
        {

        }

        public TestSystemContext(string conStr) : base(conStr)
        {

        }

        static TestSystemContext()
        {
            Database.SetInitializer<TestSystemContext>(new TestSystemContextInitializer());
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
            // many to many
            //------------------
            // User <-> Group
            modelBuilder.Entity<User>().HasMany(x => x.Groups).WithMany(y => y.Users);

            // User <-> Test
            modelBuilder.Entity<User>().HasMany(x => x.Tests).WithMany(y => y.Users);

            // many to one
            //------------------
            // Folder -> Tests
            modelBuilder.Entity<Folder>().HasMany(x => x.Tests).WithRequired(y => y.Folder).WillCascadeOnDelete(true);

            // Test -> Question
            modelBuilder.Entity<Test>().HasMany(x => x.Questions).WithRequired(y => y.Test).WillCascadeOnDelete(true);

            // Question -> Answer
            modelBuilder.Entity<Question>().HasMany(x => x.Answers).WithRequired(y => y.Question).WillCascadeOnDelete(true);

            // PassedTest -> PassedTestQuestions
            modelBuilder.Entity<PassedTest>().HasMany(x => x.PassedTestQuestions).WithRequired(y => y.PassedTest).WillCascadeOnDelete(true);

            // PassedTestQuestion -> PassedTestAnswers
            modelBuilder.Entity<PassedTestQuestion>().HasMany(x => x.PassedTestAnswers).WithRequired(y => y.PassedTestQuestion).WillCascadeOnDelete(true);

            // User -> PassedTests
            modelBuilder.Entity<User>().HasMany(x => x.PassedTests).WithRequired(y => y.User).WillCascadeOnDelete(true);

            // Test -> PassedTests
            modelBuilder.Entity<Test>().HasMany(x => x.PassedTests).WithRequired(y => y.Test).WillCascadeOnDelete(true);

            // Question -> PassedTestQuestions
            modelBuilder.Entity<Question>().HasMany(x => x.PassedTestQuestions).WithRequired(y => y.Question).WillCascadeOnDelete(true);

            // Answer -> PassedTestAnswers
            modelBuilder.Entity<Answer>().HasMany(x => x.PassedTestAnswers).WithRequired(y => y.Answer).WillCascadeOnDelete(true);
        }
    }
}
