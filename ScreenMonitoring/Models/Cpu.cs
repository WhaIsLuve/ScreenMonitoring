using System.Diagnostics;

namespace ScreenMonitoring.Models
{
    public class Cpu
    {
        public int CpuUsageInPercent
        {
            get
            {
                PerformanceCounter cpuUsageInPercent = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
                cpuUsageInPercent.NextValue();
                Thread.Sleep(100);
                return (int)Math.Ceiling(cpuUsageInPercent.NextValue());
            }
        }
    }
}
