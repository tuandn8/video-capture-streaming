using Captura;
using Captura.FFmpeg;
using Captura.Models;

namespace RecordStreamApi.Models
{
    public class MainModule : IModule
    {
        public void OnLoad(IBinder Binder)
        {
            // Use singleton to ensure the same instance is used every time.
            Binder.Bind<IMessageProvider, FakeMessageProvider>();
            Binder.Bind<IRegionProvider, FakeRegionProvider>();
            Binder.Bind<ISystemTray, FakeSystemTray>();
            Binder.Bind<IPreviewWindow, FakePreviewWindow>();
            //Binder.Bind<IVideoSourcePicker, VideoSourcePicker>();
            Binder.Bind<IAudioPlayer, FakeAudioPlayer>();
            Binder.Bind<IFFmpegViewsProvider, FFmpegViewsProvider>();

            //Binder.Bind<IHotkeyListener, HotkeyListener>();
            //Binder.Bind<IHotkeyActor, HotkeyViewActor>();

            //Binder.BindSingleton<EditorWriter>();
            //Binder.Bind<IImageWriterItem>(ServiceProvider.Get<EditorWriter>);

            //Binder.BindSingleton<AboutViewModel>();
            //Binder.BindSingleton<RegionSelectorViewModel>();

            //Binder.BindSingleton<WebcamPage>();

            // Bind as a Function to ensure the UI objects are referenced only after they have been created.
            //Binder.Bind<Func<TaskbarIcon>>(() => () => MainWindow.Instance.SystemTray);
            Binder.Bind<IMainWindow>(() => new FakeWindowProvider());
        }

        public void Dispose() { }
    }   
}
