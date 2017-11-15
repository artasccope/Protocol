using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Protocol.DTO
{
    [Serializable]
    public class SelectDTO
    {
        /// <summary>
        /// 用户id
        /// </summary>
        public int userId;
        /// <summary>
        /// 用户名字
        /// </summary>
        public string name;
        /// <summary>
        /// 所选英雄id
        /// </summary>
        public int heroId;
        /// <summary>
        /// 是否已经进入选择
        /// </summary>
        public bool isEnter;
        /// <summary>
        /// 是否已经准备好了
        /// </summary>
        public bool isReady;
        /// <summary>
        /// 玩家的英雄列表
        /// </summary>
        public int[] heroList;
    }
}
