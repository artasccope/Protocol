using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Protocol.DTO.Fight
{
    [Serializable]
    public class BuildingModel
    {
        public bool isReborn;
        public int rebornTime;
        public bool couldAttack;
        public bool isAntiStealth;//是否反隐形

        public BuildingModel() { }

        public BuildingModel(bool isReborn, int rebornTime, bool couldAttack, bool isAntiStealth) {
            this.isReborn = isReborn;
            this.rebornTime = rebornTime;
            this.couldAttack = couldAttack;
            this.isAntiStealth = isAntiStealth;
        }
    }
}
