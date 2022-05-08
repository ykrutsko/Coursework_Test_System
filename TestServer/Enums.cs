using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestServer
{
    public enum OpenMode { Add, AddByCopy, Edit }
    public enum UsersFormSelector { Active, Archived, All, ByGroup, None }
    public enum ObjectType { Group, User, Test, Question, Answer, UserTest, UserAnswer }


}
