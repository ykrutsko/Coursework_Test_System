using SHA512Lib;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALTestingSystemDB
{
    public class TestingSystemContextInitializer : CreateDatabaseIfNotExists<TestingSystemContext>
    {
        protected override void Seed(TestingSystemContext context)
        {
            User user = new User() { Login = "Admin", Password = ("admin").GetSha512(), IsAdmin = true, RegisterDate = DateTime.Now };
            context.Users.Add(user);

            Group group = new Group() { Name = "Administrators", IsAdminGroup = true };
            context.Groups.Add(group);

            group.Users.Add(user);
            context.SaveChanges();
        }
    }
}
