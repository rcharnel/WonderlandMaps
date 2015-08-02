using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game;
using Plugin;

namespace _11016
{
    public class map11016:GameMap
    {
        

        public map11016(object host, object src)
            : base((PluginHost)host, (System.IO.FileInfo)src)
        {

        }
        
        public override uint MapID
        {
            get
            {
                return 11016;
            }
        }

        public override string MapName
        {
            get
            {
                return "Cruise Ship";
            }
        }
    }
}
