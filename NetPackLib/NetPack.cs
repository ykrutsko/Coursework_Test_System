using BinObjConverterLib;
using EnumsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetPackLib
{
    public static class NetPack
    {
        public static Byte[] CreateNetPack(TcpPackType tcpPackType, Object obj)
        {
            List<byte> list = new List<byte>();
            if (obj != null)
            {
                Int32 type = Convert.ToInt32(tcpPackType);

                Byte[] objByteArr = BinObjConverter.ObjectToByteArray(obj);
                Int32 size = Convert.ToInt32(objByteArr.Length);

                list.AddRange(BitConverter.GetBytes(type));
                list.AddRange(BitConverter.GetBytes(size));
                list.AddRange(objByteArr);
            }
            else
            {
                Int32 type = Convert.ToInt32(tcpPackType);
                list.AddRange(BitConverter.GetBytes(type));
            }
            return list.ToArray();
        }
    }
}
