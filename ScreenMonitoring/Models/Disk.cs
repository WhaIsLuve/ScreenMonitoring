namespace ScreenMonitoring.Models
{
    public class Disk
    {
        public int DiskUsageInGB
        {
            get
            {
                return (int)Math.Ceiling(DriveInfo.GetDrives()[0].TotalSize / Math.Pow(2, 30) - DriveInfo.GetDrives()[0].TotalFreeSpace / Math.Pow(2, 30));
            }
        }
    }
}
