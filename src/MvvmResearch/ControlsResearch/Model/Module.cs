using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlsResearch.Model
{
   public class Module:Item
    {
        public List<Property> Properties { get; set; }
        public Module()
        {
            Properties = new List<Property>();
        }
    }
}
