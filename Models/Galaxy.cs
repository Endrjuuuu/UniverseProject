using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniverseProject.Models
{
    public class Galaxy
    {
        public string Name { get; set; }
        public GalaxyType Type { get; set; }
        public int NumberOfStars { get; set; }

        public Dictionary<string, Star> StarsDict { get; set; }

        public Galaxy(string name, GalaxyType type, int numberOfStars)
        {
            Name = name;
            Type = type;
            NumberOfStars = numberOfStars;
            StarsDict = new Dictionary<string, Star>();
        }

        public void AddStar(string name, int years)
        {
            StarsDict.Add(name, new Star(name, years));
        }
    }
}
