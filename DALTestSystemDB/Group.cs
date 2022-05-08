using System;
using System.Collections.Generic;

namespace DALTestingSystemDB
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsAdminGroup { get; set; }
        public bool IsDeletable { get; set; }
        public virtual ICollection<User> Users { get; set; }

        public Group()
        {
            Users = new List<User>();
        }

        public override string ToString()
        {
            return Name;
        }

        public Group PartClone()
        {
            ICollection<User> usersClone = new List<User>();
            foreach (User user in Users)
                usersClone.Add(user);

            return new Group
            {
                Name = this.Name,
                Description = this.Description,
                IsAdminGroup = false,
                IsDeletable = true,
                Users = usersClone
            };
        }

        public Group FullClone()
        {
            ICollection<User> usersClone = new List<User>();
            foreach (User user in Users)
                usersClone.Add(user);

            return new Group
            {
                Id = this.Id,
                Name = this.Name,
                Description = this.Description,
                IsAdminGroup = this.IsAdminGroup,
                IsDeletable = this.IsDeletable,
                Users = usersClone
            };
        }

        public void UpdateClone(Group other)
        {
            this.Name = other.Name;
            this.Description = other.Description;
            this.IsAdminGroup = other.IsAdminGroup;
            this.IsDeletable = other.IsDeletable;

            this.Users.Clear();
            foreach (User user in other.Users)
                this.Users.Add(user);
        }
    }
}