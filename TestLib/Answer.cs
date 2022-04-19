using System;

namespace TestLib
{
    [Serializable]
    public class Answer : IEquatable<Answer>
    {
        public string TextAnwer { get; set; }
        public bool IsRight { get; set; }

        public Answer() { }

        public Answer(string textAnwer, bool isRight)
        {
            TextAnwer = textAnwer;
            IsRight = isRight;
        }

        public bool Equals(Answer other)
        {
            return other is Answer && 
                TextAnwer == other.TextAnwer && 
                IsRight == other.IsRight; 
        }
    }
}