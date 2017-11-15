using Protocol.DTO.Fight.Instance;
using System;
using System.Collections.Generic;

namespace Protocol.DTO.Fight
{
    [Serializable]
    public class FightRoomDTO
    {
        public List<AbsFightInstance> entities = new List<AbsFightInstance>();
        public List<BuildingInstance> buildingEntities = new List<BuildingInstance>();
        public bool isHost;
    }
}
