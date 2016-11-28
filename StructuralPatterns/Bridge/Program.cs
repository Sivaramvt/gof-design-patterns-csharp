using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    /// <summary>
    /// Bridge - Structural pattern
    /// 
    /// Purpose:
    /// (1) Segregate abstraction from implementation
    /// 
    /// Bridge creates orthogonal hierarchy instead of parallel
    /// 
    /// Scenario:
    /// 2 kinds of thread scheduler - Timeslice based & Pre-emptive
    /// There could be multiple platforms - Windows, Unix, Linux, etc
    /// Without Bridge pattern, We have to have subclasses for Timeslice & preemptive for every platform. This is cumbersome
    ///
    /// Ref:http://sourcemaking.com/design_patterns/bridge
    /// 
    /// Partipants:
    /// Abstract Abstraction - Thread Scheduler ----> Interface Platform
    /// Concrete Abstraction - TimeSlice & Pre-empltive
    /// Interface Platform
    /// Concrete platforms - Win, Unix
    /// 
    /// For every new platform, just add single class
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IPlatformImplementation winPlatform = new WinPlatform();
            winPlatform.Name = "Windows";

            new TimeslicedThreadScheduler(winPlatform).ScheduleJob();

            Console.ReadKey();
        }
    }
}
