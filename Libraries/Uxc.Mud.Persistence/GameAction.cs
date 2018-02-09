using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uxc.Mud.Persistence
{
    //The game action consists of the directions to travel,
    //combats, and searchables
    public class GameAction
    {
        public Guid Id { get; set; }

        public string Label { get; set; }

        //Traveling is repeatable, but combat and 
        //Searches are one-time only

        public bool Repeatable { get; set; }

        public bool Executed { get; set; }
    }
}
