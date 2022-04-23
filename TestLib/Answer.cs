using System;

namespace TestLib
{
    [Serializable]
    public class Answer : IEquatable<Answer>, ICloneable
    {
        public string TextAnswer { get; set; }
        public bool IsRight { get; set; }

        public Answer() { }

        public Answer(string textAnswer, bool isRight)
        {
            TextAnswer = textAnswer;
            IsRight = isRight;
        }

        public bool Equals(Answer other)
        {
            return other is Answer &&
                TextAnswer.Equals(other.TextAnswer) && 
                IsRight.Equals(other.IsRight); 
        }

        public object Clone()
        {
            return new Answer(TextAnswer, IsRight);
        }
    }
}