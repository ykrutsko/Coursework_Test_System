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
            User admin = new User() { 
                Login = "Admin", 
                Password = ("admin").GetSha512(),
                Description = "SUPER administrator",
                FirstName = String.Empty,
                LastName = String.Empty,
                IsAdmin = true, 
                IsArchived = false,
                RegisterDate = DateTime.Now };

            User student = new User()
            {
                Login = "Student",
                Password = ("1234567").GetSha512(),
                Description = "Student of the Year 2022 Award",
                FirstName = "Dolores",
                LastName = "Woodward",
                IsAdmin = false,
                IsArchived = false,
                RegisterDate = DateTime.Now
            };

            Group admins = new Group() { 
                Name = "Administrators",
                Description = "Default administrators group",
                IsAdminGroup = true };

            Group students = new Group()
            {
                Name = "Students",
                Description = "Students 2022",
                IsAdminGroup = false
            };

            context.Users.Add(admin);
            context.Groups.Add(admins);
            context.Users.Add(student);
            context.Groups.Add(students);
            admins.Users.Add(admin);
            students.Users.Add(student);

            context.SaveChanges();
        }
    }
}
