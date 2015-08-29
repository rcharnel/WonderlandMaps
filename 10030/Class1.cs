using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game;
using Plugin;


namespace _10030
{
    public class map10030 : GameMap
    {


        public map10030(object host, object src)
            : base((PluginHost)host, (System.IO.FileInfo)src)
        {

        }

        public override uint MapID
        {
            get
            {
                return 10030;
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
