using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lianliankan
{
    class def
    {
        public const int MAXEDGE = 8;
        public const int MAXPIC = 16;
        public const int MAXTIME = 120;

        public struct coordinate 
        {
            public int x;
            public int y;
        }

        public struct queue
        {
            public coordinate place;
            public int direct;
            public int turn;
        }
    }
}
