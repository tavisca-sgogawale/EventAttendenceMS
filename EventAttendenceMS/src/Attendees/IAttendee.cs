using EventAttendenceMS.src.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventAttendenceMS.src.Attendees
{
    public interface IAttendee
    {
        string Name { get; set; }
        Guid Id { get; set; }

        void MarkAttendance(IEvent e);

    }
}
