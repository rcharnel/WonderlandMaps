using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game;
using Plugin;

namespace _60000
{
    public class map_60000:GameMap
    {
        public map_60000(object host, object src)
            : base((PluginHost)host, (System.IO.FileInfo)src)
        {

        }
        
        public override uint MapID
        {
            get
            {
                return 60000;
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
                return "North Island";
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
