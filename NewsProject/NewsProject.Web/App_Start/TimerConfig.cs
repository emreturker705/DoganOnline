using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Web;
using NewsProject.Business;

namespace NewsProject.Web
{
    public class TimerConfig
    {
        public static void Register()
        {
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 5000;
            aTimer.Enabled = true;
        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            BaseService.NewsService.SetRecentNews();
        }
    }
}