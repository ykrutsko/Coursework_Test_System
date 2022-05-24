using System.Collections.Generic;
using System.Windows.Forms;

namespace TestClient
{
    public class VisualAnswer
    {
        public int Id { get; set; }
        public string AnswerText { get; set; }
        public NetCloneLib.NetCloneUserAnswer userAnswer { get; set; }
    }
}