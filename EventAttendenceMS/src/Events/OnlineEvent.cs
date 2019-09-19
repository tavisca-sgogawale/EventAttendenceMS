using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventAttendenceMS.Attendees;

namespace EventAttendenceMS.Events
{
    public class OnlineEvent : IEvent
    {
        public Guid Id { get ; set; }
        public string Name { get ; set ; }
        public List<IAttendee> AttendeeList { get ; set ; }
        public TimeSlot TimeSlot { get ; set ; }

        public bool TryCreateEvent(Dictionary<string, string> keyValuePairs, out IEvent e)
        {
            Name = keyValuePairs["name"];

        }
    }
}
