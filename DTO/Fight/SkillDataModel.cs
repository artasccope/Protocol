using System;

namespace Protocol.DTO.Fight
{
    public enum SkillCostType {
        hp = 1,
        mp = 2,
    }

    [Serializable]
    public class SkillLevelData
    {
        public int nextLevel;//下一级的学习等级
        public int preloadTime;//前摇时间
        public int bootTime;//引导时间
        public int cdTime;//冷却时间
        public int cost;//消耗值
        public float range;//范围
        public int damage;//伤害值
        public int heal;//治愈值
        public float lastingTime;//持续时间

        public SkillLevelData() { }
        public SkillLevelData(int nextLevel, int preloadTime, int bootTime, int cdTime, int damage, int heal, float lastingTime, int cost, float range)
        {
            this.nextLevel = nextLevel;
            this.preloadTime = preloadTime;
            this.bootTime = bootTime;
            this.cdTime = cdTime;
            this.damage = damage;
            this.heal = heal;
            this.lastingTime = lastingTime;
            this.cost = cost;
            this.range = range;
        }
    }

    [Serializable]
    public class SkillDataModel
    {
        public int code;
        public string name;
        public SkillLevelData[] levels;//技能各等级对应信息
        public string info;
        public SkillTargetType targetType;//技能目标类型
        public SkillCostType costType;//技能目标类型
        public SkillType type;

        public SkillDataModel() { }

        public SkillDataModel(int code, string name, string info, SkillType type, SkillTargetType targetType, SkillCostType costType, SkillLevelData[] levels)
        {
            this.code = code;
            this.levels = levels;
            this.name = name;
            this.info = info;
            this.targetType = targetType;
            this.costType = costType;
            this.type = type;
        }

        public FightSkill GetSkillLevelOne() {
            FightSkill fightSkill = new FightSkill();
            fightSkill.code = this.code;
            fightSkill.level = 1;
            fightSkill.nextLevel = levels[0].nextLevel;
            fightSkill.preloadTime = levels[0].preloadTime;
            fightSkill.bootTime = levels[0].bootTime;
            fightSkill.cdTime = levels[0].cdTime;
            fightSkill.name = this.name;
            fightSkill.info = this.info;
            fightSkill.range = levels[0].range;
            fightSkill.skillTargetType = this.targetType;
            fightSkill.skillType = this.type;

            return fightSkill;
        }
    }
}
