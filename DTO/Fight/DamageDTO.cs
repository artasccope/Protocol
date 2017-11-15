
namespace Protocol.DTO.Fight
{
    public class DamageDTO:FightDTO
    {
        public int userId;
        public int skill;
        /// <summary>
        /// 一组damage数据为 被攻击目标id、伤害数值、是否活着(0为死、1为活)
        /// </summary>
        public int[][] targetDamages;
    }
}
