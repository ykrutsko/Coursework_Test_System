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
            User user = new User() { 
                Login = "Admin", 
                Password = ("admin").GetSha512(),
                Description = "SUPER administrator",
                FirstName = String.Empty,
                LastName = String.Empty,
                IsAdmin = true, 
                IsArchived = false,
                RegisterDate = DateTime.Now };

            Group group = new Group() { 
                Name = "Administrators",
                Description = "Default administrators group",
                IsAdminGroup = true };

            Group group1 = new Group()
            {
                Name = "Teachers",
                Description = "Math teachers",
                IsAdminGroup = false
            };

            context.Users.Add(user);
            context.Groups.Add(group);
            context.Groups.Add(group1);
            group.Users.Add(user);

            context.SaveChanges();
        }
    }
}
