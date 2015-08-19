using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game;
using Plugin;


namespace _13051
{
    public class map13051:GameMap
    {

        public map13051(object host, object src)
            : base((PluginHost)host, (System.IO.FileInfo)src)
    {

    }

        public override uint MapID
        {
            get
            {
                return 13051;
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
                return "Beach Area";
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
