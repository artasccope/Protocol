using System;
using System.Collections.Generic;
using System.Text;

namespace Protocol
{
    public delegate byte[] MessageEncode(SocketModel model);
    public delegate SocketModel MessageDecode(byte[] value);
    /// <summary>
    /// 消息对象的编解码器(编为byte[])
    /// </summary>
    public class MessageEncoder
    {
        /// <summary>
        /// 将SocketModel编码成一个byte[] (在BinaryArray和Serailizer的帮助下)
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static byte[] Encode(SocketModel model)
        {
            BinaryArray ba = new BinaryArray();
            ba.write(model.type);
            ba.write(model.area);
            ba.write(model.command);

            if (model.message != null)
                ba.write(Serializer.Encode(model.message));//序列化器负责序列化message

            byte[] result = ba.GetBuff();
            ba.Close();
            return result;
        }
        /// <summary>
        /// 消息从byte[]解码成SocketModel
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static SocketModel Decode(byte[] value)
        {
            BinaryArray ba = new BinaryArray(value);

            SocketModel model = new SocketModel();
            byte type;
            int area, command;
            ba.read(out type);
            ba.read(out area);
            ba.read(out command);
            model.type = type;
            model.area = area;
            model.command = command;

            if (ba.Readable)
            {//如果还有剩余消息字节，说明还有message
                byte[] message;
                ba.read(out message, ba.Length - ba.Position);//剩下的消息体全部拿出来
                model.message = Serializer.Decode(message);//解码成model.message
            }

            ba.Close();
            return model;
        }
    }
}
