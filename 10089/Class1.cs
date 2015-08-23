﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game;
using Plugin;

namespace _10095
{
    public class map10095 : GameMap

    {
        public map10095(object host, object src)
             : base((PluginHost)host, (System.IO.FileInfo)src)
        {

        }

        public override uint MapID
        {
            get
            {
                return 10095;
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
                return "Quiz Zone";
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
