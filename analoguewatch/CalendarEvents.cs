using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace analoguewatch
{
    public class CalendarEvents
    {
        private string title, location;

        private DateTime startDate, endDate, beginDate;

        private long duration;

        private bool allday;

        private int color;                  


        public CalendarEvents(String title, String location, int color, long startTime, long duration)
        {
            this.title = title;
            this.location = location;
            this.color = color;

        }
    }
}