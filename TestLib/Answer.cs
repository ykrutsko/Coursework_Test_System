using System;

namespace TestLib
{
    [Serializable]
    public class Answer
    {
        public string TextAnwer { get; set; }
        public bool IsRight { get; set; }

        public Answer() { }

        public Answer(string textAnwer, bool isRight)
        {
            TextAnwer = textAnwer;
            IsRight = isRight;
        }
    }
}