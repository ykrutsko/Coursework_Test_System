using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BinObjConverterLib
{
    public class BinObjConverter
    {
        public static byte[] ObjectToByteArray(Object obj)
        {
            if (obj == null)
                return null;
            using(MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }

        //public static Object ByteArrayToObject(byte[] arrBytes)
        public static Object ByteArrayToObject(byte[] arrBytes, int offset, int count)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter bf = new BinaryFormatter();
                //memStream.Write(arrBytes, 0, arrBytes.Length);
                ms.Write(arrBytes, offset, count);
                ms.Seek(0, SeekOrigin.Begin);
                Object obj = (Object)bf.Deserialize(ms);
                return obj;
            }
        }
    }
}
