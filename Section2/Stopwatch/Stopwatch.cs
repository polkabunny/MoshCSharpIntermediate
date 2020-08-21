using System;
using System.Diagnostics;

namespace Stopwatch
{
    public class Stopwatch
    {
        private TimeSpan _duration;
        private System.Diagnostics.Stopwatch _stopWatch = new System.Diagnostics.Stopwatch();

        public void Start()
        {
            if (!_stopWatch.IsRunning)
            {
                _stopWatch.Reset();
                _stopWatch.Start();
            }
            else
            {
                throw new InvalidOperationException("StopWatch is already running");
            }
        }

        public void Stop()
        {
            if (_stopWatch.IsRunning)
            {
                _stopWatch.Stop();
                _duration = _stopWatch.Elapsed;
            }
        }

        public TimeSpan GetDuration()
        {
            return _duration;
        }
    }
}
