using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateEvent
{
    class Fighter
    {
        public Fighter(string fighterName)
        {
            this.fighterName = fighterName;
        }

        public string fighterName { get; set; }
        public Fighter()
        {
        }
    }
}
