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
            //Configuration.ProxyCreationEnabled = false;
            //Configuration.LazyLoadingEnabled = false;
        }

        static TestSystemContext()
        {
            Database.SetInitializer<TestSystemContext>(new TestSystemContextInitializer());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<UserTest> PassedTests { get; set; }
        public DbSet<UserAnswer> PassedTestAnswers{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(x => x.Login).IsRequired();
            modelBuilder.Entity<User>().Property(x => x.Password).IsRequired();
            modelBuilder.Entity<Group>().Property(x => x.Name).IsRequired();
            modelBuilder.Entity<Test>().Property(x => x.Title).IsRequired();
            modelBuilder.Entity<Question>().Property(x => x.QuestionText).IsRequired();
            modelBuilder.Entity<Answer>().Property(x => x.AnswerText).IsRequired();

            // many to many
            //------------------
            // User <-> Group
            modelBuilder.Entity<User>().HasMany(x => x.Groups).WithMany(y => y.Users);

            // one to many
            //------------------
            // Test -> Question
            modelBuilder.Entity<Test>().HasMany(x => x.Questions).WithRequired(y => y.Test);

            // Question -> Answer
            modelBuilder.Entity<Question>().HasMany(x => x.Answers).WithRequired(y => y.Question);

            // User -> UserTest
            modelBuilder.Entity<User>().HasMany(x => x.UserTests).WithRequired(y => y.User);

            // Test -> UserTest
            modelBuilder.Entity<Test>().HasMany(x => x.UserTests).WithRequired(y => y.Test);

            // UserTest -> UserAnswer
            modelBuilder.Entity<UserTest>().HasMany(x => x.UserAnswers).WithRequired(y => y.UserTest);

            // Answer -> UserAnswer
            modelBuilder.Entity<Answer>().HasMany(x => x.UserAnswers).WithRequired(y => y.Answer).WillCascadeOnDelete(false);
        }
    }
}
