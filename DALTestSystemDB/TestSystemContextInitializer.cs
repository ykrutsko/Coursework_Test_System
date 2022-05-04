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
                IsAdmin = true, 
                RegisterDate = DateTime.Now };

            Group group = new Group() { 
                Name = "Administrators", 
                IsAdminGroup = true };

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
            group.Users.Add(user);

            context.Folders.Add(LOAD);
            context.Folders.Add(ARCHIVE);

            context.SaveChanges();
        }
    }
}
