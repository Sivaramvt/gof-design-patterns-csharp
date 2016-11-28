using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace Bridge
{
    class TimeslicedThreadScheduler:AbstractThreadScheduler
    {
        Timer _timer;
        

        public TimeslicedThreadScheduler(IPlatformImplementation impl)
            : base(impl)
        {
            _timer = new Timer();
        }

        public override void ScheduleJob()
        {
            _timer.Interval =200;
            _timer.Elapsed += new ElapsedEventHandler(_timer_Elapsed);
            _timer.Enabled = true;
            
   
        }

        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            _impl.AssignJob();
        }
    }
}
