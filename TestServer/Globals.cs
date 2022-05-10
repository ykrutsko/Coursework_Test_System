using DALTestingSystemDB;
using RepositoryLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestServer
{
    public static class Globals
    {
        public static GenericUnitOfWork work;
        public static IGenericRepository<User> repoUser;
        public static IGenericRepository<Group> repoGroup;
        public static IGenericRepository<DALTestingSystemDB.Test> repoTest;
        public static IGenericRepository<DALTestingSystemDB.Question> repoQuestion;
        public static IGenericRepository<DALTestingSystemDB.Answer> repoAnswer;
        public static IGenericRepository<UserTest> repoUserTest;
        public static IGenericRepository<UserAnswer> repoUserAnswer;
    }
}
