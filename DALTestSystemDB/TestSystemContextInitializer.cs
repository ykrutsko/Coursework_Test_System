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

            Folder folder = new Folder() { 
                Name = "Loaded from files", 
                Description = "Loaded tests from files are included in this folder", 
                IsDeletable = false, 
                IsEditable = false };

            context.Users.Add(user);
            context.Groups.Add(group);
            group.Users.Add(user);

            context.Folders.Add(folder);

            context.SaveChanges();
        }
    }
}
