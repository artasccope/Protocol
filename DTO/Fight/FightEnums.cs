namespace Protocol.DTO.Fight
{
    /// <summary>
    /// 战斗数据模型类型
    /// </summary>
    public enum ModelType {
        Building = 1,
        Hero = 2,
        Creature = 3,
    }
    /// <summary>
    /// 建筑类型
    /// </summary>
    public enum BuildingType {
        defenseTower = 1,
        advancedDFTower = 2,
        headQuarter = 3,
        barracks = 4,
    }

    /// <summary>
    /// 技能的目标类型
    /// </summary>
    public enum SkillTargetType
    {
        Self,//自身
        Friend_Hero,//友方英雄
        Friend_Not_Building,//友方非建筑单位
        Friend_All,
        Enemy_Hero,
        Enemy_Not_Building,
        Enemy_And_Neutral,//敌方和中立单位
        Not_Friend_all,//非友方单位
        Not_Building,
    }
    /// <summary>
    /// 技能的类型
    /// </summary>
    public enum SkillType
    {
        Self,//以自身为中心释放
        Target,//指向目标释放
        Position,//定点释放
        Passive,//被动技能
    }
}
