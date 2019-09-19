using System;

namespace EventAttendenceMS
{
    public class TimeSlot
    {
        public TimeSlot(DateTime start, DateTime end)
        {
            if ( end < start )
            {
                throw new Exception("Start Date can not be after end date.");
            }

            Start = start;
            End = end;
        }
        public DateTime Start { get; }
        public DateTime End { get; }


    }
}
