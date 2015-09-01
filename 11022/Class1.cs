using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game;
using Plugin;

namespace _10022
{
    public class map10022 : GameMap

    {
        public map10022(object host, object src)
             : base((PluginHost)host, (System.IO.FileInfo)src)
        {

        }

        public override uint MapID
        {
            get
            {
                return 10022;
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
                return "Jungle";
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
