using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventAttendenceMS.Events
{
    public class EventBuilder
    {
        IEvent _event;

        public IEvent CreateEvent(Dictionary<string,string> keyValues)
        {
            if (_event.TryCreateEvent(keyValues, out IEvent newEvent))
                return newEvent;
            return null;
        }
    }
}
