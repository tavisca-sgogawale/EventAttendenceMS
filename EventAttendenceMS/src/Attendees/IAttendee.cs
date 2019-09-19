using EventAttendenceMS.Events;
using System;

namespace EventAttendenceMS.Attendees
{
    public interface IAttendee
    {
        string Name { get; set; }
        Guid Id { get; set; }

        void MarkAttendance(IEvent e);

    }
}
