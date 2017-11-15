using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Protocol.DTO.Fight.Instance
{
    [Serializable]
    public class HeroInstance:AbsFightInstance
    {
        public int mp;
        public int atkArr;
        public int defArr;
        public int hpArr;
        public int mpArr;
        public FightSkill[] skills;
        public int skillFree;
        public int level;

        public int SkillLevel(int code)
        {
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
