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
            this.DstID = 1;
            accessBy = AccessFlags.Any;
        }

        public override ushort CickID
        {
            get
            {
                return 1;
            }
        }
    }
}
