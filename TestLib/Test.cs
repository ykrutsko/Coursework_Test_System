using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TestLib
{
    [Serializable]
    public class Test : IComparable<Test>
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Info { get; set; }
        public int PassPercent { get; set; }
        public List<Question> Questions { get; set; }

        public static XmlSerializer serializer = new XmlSerializer(typeof(Test));

        public Test()
        {
            Author = string.Empty;
            Title = string.Empty;
            Info = string.Empty;
            PassPercent = 0;
            Questions = new List<Question>();
        }

        public Test(string author, string title, string description, string info, int passPercent, List<Question> questions)
        {
            Author = author;
            Title = title;
            Description = description;
            Info = info;
            PassPercent = passPercent;
            Questions = questions;
        }

        public static void Serialize(string filePath, Test test)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, test);
            }
        }

        public static Test Deserialize(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                return serializer.Deserialize(fs) as Test;
            }
        }

        public int CompareTo(Test other)
        {
            if (other == null) return 1;
            if (other.Title != null)
                return this.Title.CompareTo(other.Title);
            else
                throw new ArgumentException("Object is not a Test");

        }
    }
}
