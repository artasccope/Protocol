using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Protocol
{
    /// <summary>
    /// 序列化器
    /// </summary>
    public class Serializer
    {
        /// <summary>
        /// 对对象进行序列化
        /// </summary>
        /// <param name="value"></param>
        public static byte[] Encode(object value)
        {
            MemoryStream ms = new MemoryStream();//内存流对象
            BinaryFormatter bf = new BinaryFormatter();//二进制格式转换器
            //将obj对象序列化成二进制对象，写入 内存流
            bf.Serialize(ms, value);
            byte[] result = new byte[ms.Length];
            Buffer.BlockCopy(ms.GetBuffer(), 0, result, 0, (int)ms.Length);
            ms.Close();
            return result;
        }
        /// <summary>
        /// 反序列化
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static object Decode(byte[] value)
        {
            MemoryStream ms = new MemoryStream(value);
            BinaryFormatter bf = new BinaryFormatter();
            object result = bf.Deserialize(ms);
            ms.Close();
            return result;
        }
    }
}
