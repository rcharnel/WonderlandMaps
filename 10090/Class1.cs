﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game;
using Plugin;

namespace _10096
{
    public class map10096 : GameMap

    {
        public map10096(object host, object src)
             : base((PluginHost)host, (System.IO.FileInfo)src)
        {

        }

        public override uint MapID
        {
            get
            {
                return 10096;
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
                return "PvP Hall 1";
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
