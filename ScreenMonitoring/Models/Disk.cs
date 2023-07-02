namespace ScreenMonitoring.Models
{
    public class Disk
    {

        public int DiskAvailableInGB
        {
            get
            {
                return (int)Math.Ceiling(DriveInfo.GetDrives()[0].TotalFreeSpace / Math.Pow(2, 30));
            }
        }
    }
}
