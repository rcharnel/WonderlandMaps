using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Maps;
using Game;

namespace _60000.WarpPortal
{
    public class ToSB : Game.Maps.WarpPortal
    {
        public ToSB()
        {
            this.clickID = 1;
            this.DstID = 1;
            accessBy = AccessFlags.Any;
        }
    }
}
