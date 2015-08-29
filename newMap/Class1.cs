using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game;
using Plugin;


namespace _newMap
{
    public class mapnewMap : GameMap
    {


        public mapnewMap(object host, object src)
            : base((PluginHost)host, (System.IO.FileInfo)src)
        {

        }

        public override uint MapID
        {
            get
            {
                return base.MapID;
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
