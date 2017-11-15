using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Protocol.DTO
{
    [Serializable]
    public class DelayAndFloating
    {
        public long delay;
        public long floating;

        public DelayAndFloating() { }

        public DelayAndFloating(long delay, long floating)
        {
            this.delay = delay;
            this.floating = floating;
        }
    }
}
