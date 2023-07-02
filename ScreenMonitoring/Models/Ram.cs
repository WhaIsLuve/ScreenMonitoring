using System.Diagnostics;

namespace ScreenMonitoring.Models
{
    public class Ram
    {

        public double RamUsageInGB
        {
            get
            {
                Process process = Process.GetCurrentProcess();
                return Math.Round((double)process.WorkingSet64 / 10000000, 1);
            }
        }
    }
}
