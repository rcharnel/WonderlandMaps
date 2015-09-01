using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game;
using Plugin;


namespace _10029
{
    public class map10029 : GameMap
    {


        public map10029(object host, object src)
            : base((PluginHost)host, (System.IO.FileInfo)src)
        {

        }

        public override uint MapID
        {
            get
            {
                return 10029;
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
