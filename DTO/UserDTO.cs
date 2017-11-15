using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Protocol.DTO
{
    [Serializable]
    public class UserDTO
    {
        public int id;
        public string name;
        public int level;
        public int exp;
        public int winCount;
        public int loseCount;
        public int ranCount;
        public int[] heroList;
        public UserDTO() { }
        public UserDTO(string name, int id, int level, int win, int lose, int ran, int[] heroList)
        {
            this.id = id;
            this.name = name;
            this.winCount = win;
            this.loseCount = lose;
            this.ranCount = ran;
            this.level = level;
            this.heroList = heroList;
        }
    }
}
