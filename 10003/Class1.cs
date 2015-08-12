using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game;
using Plugin;

namespace _10003
{
    public class map10003 : GameMap

    {
        public map10003(object host, object src)
             : base((PluginHost)host, (System.IO.FileInfo)src)
        {

        }

        public override uint MapID
        {
            get
            {
                return base.MapID;
            }

            set
            {
                base.MapID = value;
            }
        }

        public override string MapName
        {
            get
            {
                return base.MapName;
            }
        }

        public override MapType Type
        {
            get
            {
                return base.Type;
            }
        }

        public void Test()
        {

        }
    }
}
