using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game;
using Plugin;


namespace _10031
{
    public class map10031 : GameMap
    {


        public map10031(object host, object src)
            : base((PluginHost)host, (System.IO.FileInfo)src)
        {

        }

        public override uint MapID
        {
            get
            {
                return 10031;
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
