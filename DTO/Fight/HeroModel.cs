using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Protocol.DTO.Fight
{
    [Serializable]
    public class HeroModel:AbsFightModel
    {
        public int mp;
        public int atkArr;
        public int defArr;
        public int hpArr;
        public int mpArr;
        public int[] skillCodes;


    }
}
