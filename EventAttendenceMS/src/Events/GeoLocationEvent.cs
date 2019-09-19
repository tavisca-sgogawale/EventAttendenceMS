using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventAttendenceMS.Attendees;

namespace EventAttendenceMS.Events
{
    public class GeoLocationEvent : IEvent
    {
        public Guid Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<IAttendee> AttendeeList { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public TimeSlot TimeSlot { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool TryCreateEvent(Dictionary<string, string> keyValuePairs, out IEvent e)
        {
            throw new NotImplementedException();
        }
    }
}
