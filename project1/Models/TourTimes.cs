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
            public string Time;
            public bool IsAvailable;

            public TimeSlot(string time, bool avail)
            {
                Time = time;
                IsAvailable = avail;
            }
        }

        public List<TimeSlot> TimeSlots { get; set; }

        public void UpdateTimeSlot(string timeSlotToUpdate, bool newIsAvailable)
        {
            var slot = TimeSlots.FirstOrDefault(x => x.Time == timeSlotToUpdate);
            slot.IsAvailable = newIsAvailable;
        }

        public TourTimes()
        {
            TimeSlots = new List<TimeSlot>
            {
                new TimeSlot("Monday 8:00am", true),
                new TimeSlot("Monday 9:00am", true),
                new TimeSlot("Monday 10:00am", true),
                new TimeSlot("Monday 11:00am", true),
                new TimeSlot("Monday 12:00pm", true),
                new TimeSlot("Monday 1:00pm", true),
                new TimeSlot("Monday 2:00pm", true),
                new TimeSlot("Monday 3:00pm", true),
                new TimeSlot("Monday 4:00pm", true),
                new TimeSlot("Monday 5:00pm", true),
                new TimeSlot("Monday 6:00pm", true),
                new TimeSlot("Monday 7:00pm", true),
                new TimeSlot("Monday 8:00pm", true),

                new TimeSlot("Tuesday 8:00am", true),
                new TimeSlot("Tuesday 9:00am", true),
                new TimeSlot("Tuesday 10:00am", true),
                new TimeSlot("Tuesday 11:00am", true),
                new TimeSlot("Tuesday 12:00pm", true),
                new TimeSlot("Tuesday 1:00pm", true),
                new TimeSlot("Tuesday 2:00pm", true),
                new TimeSlot("Tuesday 3:00pm", true),
                new TimeSlot("Tuesday 4:00pm", true),
                new TimeSlot("Tuesday 5:00pm", true),
                new TimeSlot("Tuesday 6:00pm", true),
                new TimeSlot("Tuesday 7:00pm", true),
                new TimeSlot("Tuesday 8:00pm", true),

                new TimeSlot("Wednesday 8:00am", true),
                new TimeSlot("Wednesday 9:00am", true),
                new TimeSlot("Wednesday 10:00am", true),
                new TimeSlot("Wednesday 11:00am", true),
                new TimeSlot("Wednesday 12:00pm", true),
                new TimeSlot("Wednesday 1:00pm", true),
                new TimeSlot("Wednesday 2:00pm", true),
                new TimeSlot("Wednesday 3:00pm", true),
                new TimeSlot("Wednesday 4:00pm", true),
                new TimeSlot("Wednesday 5:00pm", true),
                new TimeSlot("Wednesday 6:00pm", true),
                new TimeSlot("Wednesday 7:00pm", true),
                new TimeSlot("Wednesday 8:00pm", true),

                new TimeSlot("Thursday 8:00am", true),
                new TimeSlot("Thursday 9:00am", true),
                new TimeSlot("Thursday 10:00am", true),
                new TimeSlot("Thursday 11:00am", true),
                new TimeSlot("Thursday 12:00pm", true),
                new TimeSlot("Thursday 1:00pm", true),
                new TimeSlot("Thursday 2:00pm", true),
                new TimeSlot("Thursday 3:00pm", true),
                new TimeSlot("Thursday 4:00pm", true),
                new TimeSlot("Thursday 5:00pm", true),
                new TimeSlot("Thursday 6:00pm", true),
                new TimeSlot("Thursday 7:00pm", true),
                new TimeSlot("Thursday 8:00pm", true),

                new TimeSlot("Friday 8:00am", true),
                new TimeSlot("Friday 9:00am", true),
                new TimeSlot("Friday 10:00am", true),
                new TimeSlot("Friday 11:00am", true),
                new TimeSlot("Friday 12:00pm", true),
                new TimeSlot("Friday 1:00pm", true),
                new TimeSlot("Friday 2:00pm", true),
                new TimeSlot("Friday 3:00pm", true),
                new TimeSlot("Friday 4:00pm", true),
                new TimeSlot("Friday 5:00pm", true),
                new TimeSlot("Friday 6:00pm", true),
                new TimeSlot("Friday 7:00pm", true),
                new TimeSlot("Friday 8:00pm", true),

                new TimeSlot("Saturday 8:00am", true),
                new TimeSlot("Saturday 9:00am", true),
                new TimeSlot("Saturday 10:00am", true),
                new TimeSlot("Saturday 11:00am", true),
                new TimeSlot("Saturday 12:00pm", true),
                new TimeSlot("Saturday 1:00pm", true),
                new TimeSlot("Saturday 2:00pm", true),
                new TimeSlot("Saturday 3:00pm", true),
                new TimeSlot("Saturday 4:00pm", true),
                new TimeSlot("Saturday 5:00pm", true),
                new TimeSlot("Saturday 6:00pm", true),
                new TimeSlot("Saturday 7:00pm", true),
                new TimeSlot("Saturday 8:00pm", true),
            };
        }
    }
}
