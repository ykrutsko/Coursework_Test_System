using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SHA512Lib;

namespace DALTestingSystemDB
{
    public class TestSystemContextInitializer : CreateDatabaseIfNotExists<TestSystemContext>
    {
        protected override void Seed(TestSystemContext context)
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
