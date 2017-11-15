using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Protocol.DTO
{
    [Serializable]
    public class SelectRoomDTO
    {
        public SelectDTO[] teamOne;
        public SelectDTO[] teamTwo;
        public int SelfUserId;

        public int GetTeam(int userId) {
            int i;
            for (i = 0; i < teamOne.Length; i++) {
                if (teamOne[i].userId == userId)
                    return 1;
            }
            for (i = 0; i < teamTwo.Length; i++) {
                if (teamTwo[i].userId == userId)
                    return 2;
            }
            return -1;
        }
    }
}
