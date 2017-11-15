using System;
using System.Collections.Generic;
using System.Text;

namespace Protocol
{
    /// <summary>
    /// 战斗协议
    /// </summary>
    public class FightProtocol
    {
        /// <summary>
        /// 加载完成，进入游戏(需要数据)
        /// </summary>
        public const int ENTER_CREQ = 0;
        /// <summary>
        /// 所有人加载完成，开始游戏
        /// </summary>
        public const int START_BRO = 1;
        /// <summary>
        /// 申请待机
        /// </summary>
        public const int IDLE_CREQ = 2;
        /// <summary>
        /// 群发待机
        /// </summary>
        public const int IDLE_BRO = 3;

        /// <summary>
        /// 客户主机发出位置同步请求
        /// </summary>
        public const int POS_SYNC_CREQ = 4;
        /// <summary>
        /// 群发位置同步
        /// </summary>
        public const int POS_SYNC_BRO = 5;
        /// <summary>
        /// 服务器发出向某地攻击指令
        /// </summary>
        public const int ATK_TO_POS_SCMD = 6;
        /// <summary>
        /// 申请一条路径
        /// </summary>
        public const int MOVE_CREQ = 7;
        /// <summary>
        /// 返回一个目标点
        /// </summary>
        public const int MOVE_TARGET_SRES = 8;
        /// <summary>
        /// 客户主机或玩家申请攻击
        /// </summary>
        public const int ATTACK_CREQ = 11;
        /// <summary>
        /// 群发播放攻击
        /// </summary>
        public const int ATTACK_BRO = 12;
        /// <summary>
        /// 伤害事件申请
        /// </summary>
        public const int DAMAGE_CREQ = 13;
        /// <summary>
        /// 群发伤害
        /// </summary>
        public const int DAMAGE_BRO = 14;
        /// <summary>
        /// 申请释放技能
        /// </summary>
        public const int SKILL_CREQ = 15;
        /// <summary>
        /// 群发播放技能
        /// </summary>
        public const int SKILL_BRO = 16;
        /// <summary>
        /// 申请技能升级
        /// </summary>
        public const int SKILL_UP_CREQ = 17;
        /// <summary>
        /// 返回升级结果
        /// </summary>
        public const int SKILL_UP_SRES = 18;
    }
}
