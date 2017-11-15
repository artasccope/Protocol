using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Protocol.DTO.Fight.Instance
{
    [Serializable]
    public class AbsFightInstance
    {
        public int instanceId;
        public byte teamId;
        public int hp;
        public int atk;//攻击力
        public int def;//防御力
        public float speed;//移动速度
        public float atkSpeed;//攻击速度
        public float atkRange;//攻击范围
        public float eyeRange;//视野范围
        public string name;
        public float posX;
        public float posY;
        public float posZ;
        public AbsFightModel fightModel;//数据模型
    }
}
