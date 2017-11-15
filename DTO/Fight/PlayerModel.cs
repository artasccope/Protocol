using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Protocol.DTO.Fight
{
    public class PlayerModel:AbsFightModel
    {
        public int level;
        public int exp;
        public int freeSkillPoint;
        public int money;
        public int[] equips;
        public FightSkill[] skills;
        public int mp;
        public int maxMp;

        public int SkillLevel(int code) {
            foreach (FightSkill item in skills)
            {
                if (item.code == code)
                {
                    return item.level;
                }
            }
            return -1;
        }
    }
}
