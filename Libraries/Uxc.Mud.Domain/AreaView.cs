using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uxc.Mud.Domain
{
    public class AreaView
    {
        public string Name { get; set; }
        public string ImageFileName { get; set; }
        public string Description { get; set; }
        public List<Action> Actions { get; set; }
    }
}
