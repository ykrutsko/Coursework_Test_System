﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib
{
    [Serializable]
    public class Question : IEquatable<Question>, ICloneable
    {
        public string QuestionText { get; set; }
        public int Points { get; set; }     // ваговий коефіцієнт
        public string Img { get; set; }
        public List<Answer> Answers { get; set; }

        public Question()
        {
            QuestionText = String.Empty;
            Points = 0;
            Img = String.Empty;
            Answers = new List<Answer>();
        }

        public Question(Question question)
        {
            QuestionText = question.QuestionText;
            Points = question.Points;
            Img = question.Img;
            Answers = question.Answers.Clone<Answer>();
        }

        public Question(string questionText, int points, string img)
        {
            QuestionText = questionText;
            Points = points;
            Img = img;
            Answers = new List<Answer>();
        }

        public Question(string questionText, int points, string img, List<Answer> answers)
        {
            QuestionText = questionText;
            Points = points;
            Img = img; 
            Answers = answers;
        }

        public bool Equals(Question other)
        {
            return other is Question &&
                this.QuestionText.Equals(other.QuestionText) &&
                this.Points == other.Points &&
                this.Img.Equals(other.Img) &&
                this.Answers.ScrambledEquals<Answer>(other.Answers);
        }

        public object Clone()
        {
            return new Question(this.QuestionText, this.Points, this.Img, this.Answers.Clone<Answer>());
        }
    }
}
