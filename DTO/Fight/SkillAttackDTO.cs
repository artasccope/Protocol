using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Protocol.DTO.Fight
{
    public class SkillAttackDTO:FightDTO
    {
        public int userId;
        public int skillType;//0表示目标攻击 1表示指定点
        public int skillCode;
        public float[] position;
        public int target;
    }
}
