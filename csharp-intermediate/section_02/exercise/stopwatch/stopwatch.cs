using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial
{
    public class StopWatch
    {
        private DateTime _StartTime { get; set; }
        private DateTime _EndTime { get; set; }
        private bool _running = false;

        public void Start(DateTime start)
        {
            if(!_running)
            {
                _StartTime = start;
            }
            else
            {
                Console.WriteLine("Stopwatch is already running");
            }
        }

        public void Stop(DateTime stop)
        {
            if(_running)
            {
                _EndTime = stop;
                _running = false;
            }
        }

        public TimeSpan GetInterval()
        {
            var duration = _EndTime - _StartTime;
            return duration;
        }
    }
}
