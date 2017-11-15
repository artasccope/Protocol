using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Protocol.DTO
{
    [Serializable]
    public class DelayCheckDTO
    {
        public int checkNum;//延迟检查的次数
        public List<long> timeStamps;

        public DelayCheckDTO(int checkNum) {
            this.checkNum = checkNum;
            timeStamps = new List<long>(checkNum);
        }
    }
}
