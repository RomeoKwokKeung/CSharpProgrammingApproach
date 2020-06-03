using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shooter
{
    static class GlobalClass
    {
        private static int globalVar = 0;

        //This will allow us to access the variable 
        //from any form
        public static int GlobalVar
        {
            get { return globalVar; }
            set { globalVar = value; }
        }

    }
}
