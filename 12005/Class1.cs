using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game;
using Plugin;


namespace _12005
{
    public class map12005:GameMap
    {


        public map12005(object host, object src)
            : base((PluginHost)host, (System.IO.FileInfo)src)
        {

        }

        public override uint MapID;
        {
           get
            {
                return 12005;
            }
        }

        public override string MapName;
        {
            get
            {
                return "Kelan Cave 1F";
            }
        }

       public void Test()
        {



        }
    }
}
