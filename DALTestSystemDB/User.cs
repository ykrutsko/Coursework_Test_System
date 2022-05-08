using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DALTestingSystemDB
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsArhived { get; set; }
        public DateTime RegisterDate { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<UserTest> UserTests { get; set; }

        public User()
        {
            Groups = new List<Group>();
            UserTests = new List<UserTest>();
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " (" + Login + ")";
        }

        public User PartClone()
        {
            ICollection<Group> groupsClone = new List<Group>();
            foreach (Group group in Groups)
                groupsClone.Add(group);

            ICollection<UserTest> userTestsClone = new List<UserTest>();
            foreach (UserTest userTest in userTestsClone)
                userTestsClone.Add(userTest);

            return new User
            {
                FirstName = this.FirstName,
                LastName = this.LastName,
                Login = this.Login,
                Description = this.Description,
                IsAdmin = this.IsAdmin,
                IsArhived = false,
                Groups = groupsClone,
                UserTests = userTestsClone
            };
        }

        public User FullClone()
        {
            ICollection<Group> groupsClone = new List<Group>();
            foreach (Group group in Groups)
                groupsClone.Add(group);

            return new User
            {
                Id = this.Id,
                FirstName = this.FirstName,
                LastName = this.LastName,
                Login = this.Login,
                Password = this.Password,
                Description = this.Description,
                IsAdmin = this.IsAdmin,
                IsArhived = this.IsArhived,
                RegisterDate = this.RegisterDate,
                Groups = groupsClone,
            };            
        }

        public void UpdateClone(User other)
        {
            this.FirstName = other.FirstName;
            this.LastName = other.LastName;
            this.Login = other.Login;
            this.Password = other.Password;
            this.Description = other.Description;
            this.IsAdmin = other.IsAdmin;
            this.IsArhived = other.IsArhived;
            this.RegisterDate = other.RegisterDate;

            this.Groups.Clear();
            foreach (Group group in other.Groups)
                this.Groups.Add(group);
        }
    }
}
