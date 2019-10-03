using Captura;
using Captura.Models;
using Captura.ViewModels;

namespace RecordStreamApi.Models
{
    public class ServiceLocator
    {
        static ServiceLocator()
        {
            ServiceProvider.LoadModule(new MainModule());
        }

        public MainViewModel MainViewModel => ServiceProvider.Get<MainViewModel>();

        public RecentViewModel RecentViewModel => ServiceProvider.Get<RecentViewModel>();

        public ScreenShotViewModel ScreenShotViewModel => ServiceProvider.Get<ScreenShotViewModel>();

        public FFmpegDownloadViewModel FFmpegDownloadViewModel => ServiceProvider.Get<FFmpegDownloadViewModel>();

        public FFmpegLogViewModel FFmpegLog => ServiceProvider.Get<FFmpegLogViewModel>();

        public FFmpegCodecsViewModel FFmpegCodecsViewModel => ServiceProvider.Get<FFmpegCodecsViewModel>();

        public ProxySettingsViewModel ProxySettingsViewModel => ServiceProvider.Get<ProxySettingsViewModel>();

        public LicensesViewModel LicensesViewModel => ServiceProvider.Get<LicensesViewModel>();

        public CrashLogsViewModel CrashLogsViewModel => ServiceProvider.Get<CrashLogsViewModel>();

        public FileNameFormatViewModel FileNameFormatViewModel => ServiceProvider.Get<FileNameFormatViewModel>();

        public YouTubeUploaderViewModel YouTubeUploaderViewModel => ServiceProvider.Get<YouTubeUploaderViewModel>();

        public SoundsViewModel SoundsViewModel => ServiceProvider.Get<SoundsViewModel>();

        public KeymapViewModel Keymap => ServiceProvider.Get<KeymapViewModel>();
        
        public HotkeysViewModel HotkeysViewModel => ServiceProvider.Get<HotkeysViewModel>();

        public IIconSet Icons => ServiceProvider.Get<IIconSet>();

        public UpdateCheckerViewModel UpdateCheckerViewModel => ServiceProvider.Get<UpdateCheckerViewModel>();

        public CustomImageOverlaysViewModel CustomImageOverlays => ServiceProvider.Get<CustomImageOverlaysViewModel>();

        public CustomOverlaysViewModel CustomOverlays => ServiceProvider.Get<CustomOverlaysViewModel>();

        public CensorOverlaysViewModel CensorOverlays => ServiceProvider.Get<CensorOverlaysViewModel>();

        public ViewConditionsModel ViewConditions => ServiceProvider.Get<ViewConditionsModel>();

        public TimerModel TimerModel => ServiceProvider.Get<TimerModel>();

        public AudioSourceViewModel AudioSourceViewModel => ServiceProvider.Get<AudioSourceViewModel>();

        public WebcamModel WebcamModel => ServiceProvider.Get<WebcamModel>();

        public VideoWritersViewModel VideoWritersViewModel => ServiceProvider.Get<VideoWritersViewModel>();

        public VideoSourcesViewModel VideoSourcesViewModel => ServiceProvider.Get<VideoSourcesViewModel>();

        public RecordingViewModel RecordingViewModel => ServiceProvider.Get<RecordingViewModel>();

        public RecordStreamViewModel RecordStreamViewModel => ServiceProvider.Get<RecordStreamViewModel>();
    }
}
