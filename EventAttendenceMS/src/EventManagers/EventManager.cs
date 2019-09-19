using EventAttendenceMS.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventAttendenceMS.EventManagers
{
    public class EventManager
    {
        Dictionary<Guid,IEvent> Events {get;set;}

        public void CreateEvent(IEvent @event)
        {
            Events.Add(@event.Id, @event);
        }

        public void DeleteEvent(Guid id)
        {
            Events.Remove(id);
        }

        public void ModifyEvent(Guid id,IEvent @event)
        {
            Events[id] = @event;
        }
    }
}
