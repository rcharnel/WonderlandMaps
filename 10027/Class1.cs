using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game;
using Plugin;


namespace _10027
{
    public class _10027 : GameMap
    {


        public _10027(object host, object src)
            : base((PluginHost)host, (System.IO.FileInfo)src)
        {

        }

        public override uint MapID
        {
            get
            {
                return 10027;
            }
        }

        public override string MapName
        {
            get
            {
                return "Beach";
            }
        }

        public void Test()
        {



        }

    }
}
