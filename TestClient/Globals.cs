using NetCloneLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TestClient
{
    public class Globals
    {
        public static TcpClient client;
        public static int userId;
        public static string userToString;
        public static List<NetCloneUserTest> userTests = new List<NetCloneUserTest>();
        public static NetCloneUserTest currUserTest;
    }
}
