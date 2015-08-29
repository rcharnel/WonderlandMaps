using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game;
using Plugin;


namespace _10032
{
    public class map10032 : GameMap
    {


        public map10032(object host, object src)
            : base((PluginHost)host, (System.IO.FileInfo)src)
        {

        }

        public override uint MapID
        {
            get
            {
                return 10032;
            }
        }

        public override string MapName
        {
            get
            {
                return "Newbie Island";
            }
        }

        public void Test()
        {



        }

    }
}
