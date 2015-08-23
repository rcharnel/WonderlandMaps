using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game;
using Game.Maps;
using Network;

namespace _11016.Npcs
{
    public class Monkey : QuestNpc
    {
        public override ushort CickID
        {
            get
            {
                return 1;
            }
        }

        public override string Name
        {
            get
            {
                return "Monkey";
            }
        }

        public override Game.MapObjType Type
        {
            get
            {
                return Game.MapObjType.Npc;
            }
        }

        public override void EvaluateQuestData(Player src)
        {
            base.EvaluateQuestData(src);
        }

        public override void Interact(Player src, byte? answer = null)
        {
            src.Send(Tools.FromFormatToArray("bbb", 6, 2, 1));
            base.Interact(src, answer);
        }
    }

}
