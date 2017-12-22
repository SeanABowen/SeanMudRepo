using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uxc.Mud.Persistence
{
    public class Area
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ID { get; set; }

        //when the Areas are randomly generated,
        //their respective actions are stored here
        public List<GameAction> PossibleActions { get; set; }


    }
}
