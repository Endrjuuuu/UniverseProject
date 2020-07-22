using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniverseProject.Models
{
    public class Star
    {
        public string Name { get; set; }
        public int Years { get; set; }

        public Star(string name, int years)
        {
            Name = name;
            Years = years;
        }
    }
}
