using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project1.Models
{
    public class TourTimes
    {
        public class TimeSlot
        {
            string Time;
            bool IsAvailable;

            public TimeSlot(string time, bool avail)
            {
                Time = time;
                IsAvailable = avail;
            }
        }

        public List<TimeSlot> TimeSlots { get; set; }


        public TourTimes()
        {
            TimeSlots = new List<TimeSlot>
            {
                new TimeSlot("Monday 8:00am", true),
                new TimeSlot("Monday 9:00am", true)
            };
        }
    }
}
