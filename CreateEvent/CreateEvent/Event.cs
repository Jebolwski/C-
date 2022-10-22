using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateEvent
{
    class Event
    {
        public string eventName { get; set; }
        public int eventYear { get; set; }

        public ArrayList eventFights { get; set; }
        
        public Event()
        {

        }

        public Event(string eventName, int eventYear, ArrayList eventFights)
        {
            this.eventName = eventName;
            this.eventYear = eventYear;
            this.eventFights = eventFights;
        }
    }
}
