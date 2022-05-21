using BinObjConverterLib;
using EnumsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetPackLib
{
    [Serializable]
    public class DataPart
    {
        public string Id { get; set; }
        public int PartCount { get; set; }
        public int PartNum { get; set; }
        public byte[] Buffer { get; set; }

        public override string ToString()
        {
            return PartCount + " | " + PartNum + " | " + Buffer.Length.ToString();
        }
    }

    public class DataPartCreate
    {
        List<DataPart> dataParts = new List<DataPart>();

        public static List<Byte[]> CreateDataParts(TcpPackType tcpPackType, Object obj = null)
        {
            List<Byte[]> list = new List<Byte[]>();
            if (obj != null)
            {
                Int32 type = Convert.ToInt32(tcpPackType);
                Byte[] objByteArr = BinObjConverter.ObjectToByteArray(obj);

                byte[][] bufferArray = BufferSplit(objByteArr, 60416);
                string id = GenerateId();

                for (int i = 0; i < bufferArray.Length; i++)
                {
                    DataPart dataPart = new DataPart() { Id = id, PartCount = bufferArray.Length, PartNum = i, Buffer = bufferArray[i] };
                    list.Add(DataPack.CreateDataPack(tcpPackType, dataPart));
                }
            }
            else
            {
                DataPart dataPart = new DataPart() { Id = GenerateId(), PartCount = 1, PartNum = 0, Buffer = null };
                list.Add(DataPack.CreateDataPack(tcpPackType, dataPart));
            }

            return list;
        }

        public static byte[][] BufferSplit(byte[] buffer, int blockSize)
        {
            byte[][] blocks = new byte[(buffer.Length + blockSize - 1) / blockSize][];
            for (int i = 0, j = 0; i < blocks.Length; i++, j += blockSize)
            {
                blocks[i] = new byte[Math.Min(blockSize, buffer.Length - j)];
                Array.Copy(buffer, j, blocks[i], 0, blocks[i].Length);
            }
            return blocks;
        }

        public static string GenerateId()
        {
            return Guid.NewGuid().ToString("N");
        }
    }











}
