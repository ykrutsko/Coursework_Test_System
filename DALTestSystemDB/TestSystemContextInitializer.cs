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
                IsAdmin = true, 
                IsArhived = false,
                RegisterDate = DateTime.Now };

            Group group = new Group() { 
                Name = "Administrators",
                Description = "Default administrators group",
                IsAdminGroup = true };

            Group group1 = new Group()
            {
                Name = "Teachers",
                Description = "Math teachers",
                IsAdminGroup = true
            };

            Folder LOAD = new Folder()
            {
                Name = "LOAD",
                Description = "Loaded tests from files are here",
                IsDeletable = false,
                IsEditable = false
            };

            Folder ARCHIVE = new Folder()
            {
                Name = "ARCHIVE",
                Description = "Obsolete tests can be here",
                IsDeletable = false,
                IsEditable = false
            };

            context.Users.Add(user);
            context.Groups.Add(group);
            context.Groups.Add(group1);
            group.Users.Add(user);

            context.Folders.Add(LOAD);
            context.Folders.Add(ARCHIVE);

            context.SaveChanges();
        }
    }
}
