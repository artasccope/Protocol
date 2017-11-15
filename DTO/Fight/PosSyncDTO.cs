using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Protocol.DTO.Fight
{
    [Serializable]
    public class PosSyncDTO:FightDTO
    {
        public int instanceId;
        public float x;
        public float y;
        public float z;

        //方向信息(包含速度)
        public float dirX;
        public float dirY;
        public float dirZ;

        public PosSyncDTO(int instanceId, float posX, float posY, float posZ, float dirX, float dirY, float dirZ, long timeStamp) {
            this.instanceId = instanceId;
            this.x = posX;
            this.y = posY;
            this.z = posZ;
            this.dirX = dirX;
            this.dirY = dirY;
            this.dirZ = dirZ;
            this.timeStamp = timeStamp;
        }
    }
}
