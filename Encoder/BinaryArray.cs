using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Protocol
{
    /// <summary>
    /// 二进制数组(将数据写成二进制)
    /// </summary>
    public class BinaryArray
    {
        MemoryStream ms = new MemoryStream();
        BinaryReader br;
        BinaryWriter bw;
        /// <summary>
        /// 无参构造
        /// </summary>
        public BinaryArray()
        {
            br = new BinaryReader(ms);
            bw = new BinaryWriter(ms);
        }

        /// <summary>
        /// 传入初始数据的构造
        /// </summary>
        /// <param name="value"></param>
        public BinaryArray(byte[] value)
        {
            ms = new MemoryStream(value);
            br = new BinaryReader(ms);
            bw = new BinaryWriter(ms);
        }

        public int Position
        {
            get
            {
                return (int)ms.Position;
            }
        }

        public int Length
        {
            get
            {
                return (int)ms.Length;
            }
        }
        /// <summary>
        /// 是否还有数据可以读取
        /// </summary>
        public bool Readable
        {
            get
            {
                return ms.Length > ms.Position;
            }
        }

        public void Reposition()
        {
            ms.Position = 0;
        }

        public byte[] GetBuff()
        {
            byte[] result = new byte[ms.Length];
            Buffer.BlockCopy(ms.GetBuffer(), 0, result, 0, (int)ms.Length);
            return result;
        }

        #region 各种类型的读写操作
        public void write(int value)
        {
            bw.Write(value);
        }

        public void write(bool value)
        {
            bw.Write(value);
        }

        public void write(string value)
        {
            bw.Write(value);
        }

        public void write(byte value)
        {
            bw.Write(value);
        }

        public void write(byte[] value)
        {
            bw.Write(value);
        }

        public void write(double value)
        {
            bw.Write(value);
        }

        public void write(float value)
        {
            bw.Write(value);
        }

        public void write(long value)
        {
            bw.Write(value);
        }

        public void read(out int value)
        {
            value = br.ReadInt32();
        }

        public void read(out bool value)
        {
            value = br.ReadBoolean();
        }

        public void read(out string value)
        {
            value = br.ReadString();
        }

        public void read(out byte value)
        {
            value = br.ReadByte();
        }

        public void read(out byte[] value, int count)
        {
            value = br.ReadBytes(count);
        }

        public void read(out float value)
        {
            value = br.ReadSingle();
        }

        public void read(out double value)
        {
            value = br.ReadDouble();
        }

        public void read(out long value)
        {
            value = br.ReadInt64();
        }

        #endregion


        public void Close()
        {
            bw.Close();
            br.Close();
            ms.Close();
        }
    }
}
