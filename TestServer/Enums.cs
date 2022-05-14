using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestServer
{
    public enum OpenMode 
    { 
        Add, 
        AddByCopy, 
        Edit, 
        NewUserForGroup, 
        NewGroupForUser,
        NewTestForUser, 
        NewTestForGroup, 
        SelectTest,
        SelectUser
    }
    public enum FormSelector { Active, Archived, All, ByGroup, ByUser, ByTest, ByUserAndTest, None }
}
