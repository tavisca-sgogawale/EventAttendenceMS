using System;

namespace EventAttendenceMS.src
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
        public DateTime Start { get; set; }
        public DateTime End { get; set; }


    }
}
