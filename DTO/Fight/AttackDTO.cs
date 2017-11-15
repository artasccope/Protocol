using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Protocol.DTO.Fight
{
    [Serializable]
    public class AttackDTO:FightDTO
    {
        public int attackerId;
        public int targetId;

        public AttackDTO() { }
        public AttackDTO(int attackerId, int targetId, long timeStamp) {
            this.attackerId = attackerId;
            this.targetId = targetId;
            this.timeStamp = timeStamp;
        }
    }
}
