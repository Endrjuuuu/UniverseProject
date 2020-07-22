using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniverseProject.Models
{
    public sealed class Universe
    {
        private static readonly Universe universeInstance = new Universe();

        static Universe()
        {
        }

        private Universe()
        {
        }

        public static Universe UniverseInstance
        {
            get
            {
                return universeInstance;
            }
        }

        public Dictionary<string, Galaxy> GalaxyDict { get; set; } = new Dictionary<string, Galaxy>();

    }
}
