namespace Xiazaibao.Remote.Models
{
    public class SettingsResult : BaseResult
    {
        public int AutoDlSubtitle { get; set; }

        public int AutoOpenVip { get; set; }

        public string DefaultPath { get; set; }

        public int DownloadSpeedLimit { get; set; }

        public int MaxRunTaskNumber { get; set; }

        public int SlEndTime { get; set; }

        public int SlStartTime { get; set; }

        public int SyncRange { get; set; }

        public int UploadSpeedLimit { get; set; }
    }
}