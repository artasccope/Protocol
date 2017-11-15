using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Protocol.DTO.Fight
{
    [Serializable]
    public class FightSkill
    {
        public int code;
        public int level;
        public int nextLevel;//升级需要的角色等级
        public int preloadTime;//前摇时间
        public int bootTime;//技能引导时间
        public int cdTime;//冷却时间 以1ms为单位
        public string name;
        public string info;
        public float range;
        public SkillTargetType skillTargetType;
        public SkillType skillType;

        public FightSkill() { }

        public FightSkill(int code, int level, int nextLevel, int preloadTime, int bootTime, int cdTime, float range, string name, string info, SkillTargetType targetType, SkillType skillType) {
            this.code = code;
            this.level = level;
            this.nextLevel = nextLevel;
            this.preloadTime = preloadTime;
            this.bootTime = bootTime;
            this.cdTime = cdTime;
            this.range = range;
            this.name = name;
            this.info = info;
            this.skillTargetType = targetType;
            this.skillType = skillType;
        }
    }
}
