using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib
{
    [Serializable]
    public class Question : IEquatable<Question>
    {
        public string QuestionText { get; set; }
        public int Points { get; set; }     // ваговий коефіцієнт
        public byte[] ImageByteArray { get; set; }
        public List<Answer> Answers { get; set; }

        public Question()
        {
            QuestionText = String.Empty;
            Points = 0;
            Answers = new List<Answer>();
        }

        public Question(string questionText, int points, byte[] imageByteArray, List<Answer> answers)
        {
            QuestionText = questionText;
            Points = points;
            ImageByteArray = imageByteArray;
            Answers = answers;
        }

        // Bitmap-to-ByteArray, ByteArray-to-Bitmap  
        //--------------------------------------------
        public void ImageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                ImageConverter imageConverter = new ImageConverter();
                ImageByteArray = (byte[])imageConverter.ConvertTo(imageIn, typeof(byte[]));
            }
        }

        public Image ByteArrayToImage()
        {
            using (var ms = new MemoryStream(ImageByteArray))
            {
                return Image.FromStream(ms);
            }
        }

        public bool Equals(Question other)
        {
            return other is Question &&
                this.QuestionText == other.QuestionText &&
                this.Points == other.Points &&
                this.ImageByteArray.SequenceEqual(other.ImageByteArray) &&
                this.Answers.SequenceEqual(other.Answers);
        }
    }
}
