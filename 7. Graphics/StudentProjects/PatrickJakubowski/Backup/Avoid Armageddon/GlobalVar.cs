using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Avoid_Armageddon
{
    public static class GlobalVar
    {

        private static int Difficulty = 1;
        private static int Music = 1;

        public static int GblDifficulty
        {
            get { return Difficulty; }
            set { Difficulty = value; }
        }

        public static int GblMusic
        {
            get { return Music; }
            set { Music = value; }
        }
    }
}
