using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Protocol.DTO.Fight
{
    [Serializable]
    public class PathRequestDTO
    {
        public int instanceId;
        public float srcX;
        public float srcY;
        public float srcZ;
        public float tarX;
        public float tarY;
        public float tarZ;
        public PathRequestDTO(int instanceId, float srcX, float srcY, float srcZ, float tarX, float tarY, float tarZ) {
            this.instanceId = instanceId;
            this.srcX = srcX;
            this.srcY = srcY;
            this.srcZ = srcZ;
            this.tarX = tarX;
            this.tarY = tarY;
            this.tarZ = tarZ;
        }
    }
}
