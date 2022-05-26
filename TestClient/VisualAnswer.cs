using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TestClient
{
    [Serializable]
    public class VisualAnswer
    {
        public int Id { get; set; }
        public string AnswerText { get; set; }
        public int IdUserAnswer { get; set; }
        public bool IsChecked { get; set; }
    }
}