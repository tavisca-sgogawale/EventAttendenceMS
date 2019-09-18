using EventAttendenceMS.src.Attendees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventAttendenceMS.src.Events
{
    public interface IEvent
    {
        Guid Id { get; set; }
        string Name { get; set; }
        List<IAttendee> AttendeeList { get; set; } 
        TimeSlot TimeSlot { get; set; }
    }
}
