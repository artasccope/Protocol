using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Protocol.DTO.Fight
{
    [Serializable]
    public class AbsFightModel
    {
        public int id;
        public byte category;
        public int specieId;//模型识别码
        public int maxHp;//最大血量
        public int atk;//攻击力
        public int def;//防御力
        public string name;//名字
        public float speed;//移动速度
        public float atkSpeed;//攻击速度
        public float atkRange;//攻击范围
        public float eyeRange;//视野范围
    }
}
