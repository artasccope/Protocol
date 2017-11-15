using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Protocol.DTO.Fight
{
    [Serializable]
    public class PosDTO:FightDTO
    {
        public int instanceId;
        public float posX;
        public float posY;
        public float posZ;

        public PosDTO() { }
        public PosDTO(int instanceId, float posX, float posY, float posZ, long timeStamp) {
            this.instanceId = instanceId;
            this.posX = posX;
            this.posY = posY;
            this.posZ = posZ;
            this.timeStamp = timeStamp;
        }
    }
}
