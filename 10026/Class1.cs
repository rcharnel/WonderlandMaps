using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game;
using Plugin;


namespace _10026
{
    public class map10026 : GameMap
    {


        public map10026(object host, object src)
            : base((PluginHost)host, (System.IO.FileInfo)src)
        {

        }

        public override uint MapID
        {
            get
            {
                return 10026;
    }
        }

        public override string MapName
        {
            get
            {
                return "Cabin";
            }
        }

        public void Test()
        {



        }

    }
}
