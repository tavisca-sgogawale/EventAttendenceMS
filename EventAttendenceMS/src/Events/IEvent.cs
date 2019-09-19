using EventAttendenceMS.Attendees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventAttendenceMS.Events
{
    public interface IEvent
    {
        Guid Id { get; set; }
        string Name { get; set; }
        List<IAttendee> AttendeeList { get; set; } 
        TimeSlot TimeSlot { get; set; }
        EventType EventType { get; set; }
        bool TryCreateEvent(Dictionary<string, string> keyValuePairs, out IEvent e);
    }
}
