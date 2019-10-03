using System;
using System.Linq;
using System.Windows.Input;
using Captura;
using Captura.FFmpeg;
using Captura.Models;
using Captura.ViewModels;

namespace RecordStreamApi.Models
{
    public class RecordStreamViewModel : ViewModelBase
    {
        public ICommand RecordCommand { get; set; }
        public ICommand PauseCommand { get; set; }

        private readonly VideoSourcesViewModel videoSourceViewModel;
        private readonly VideoWritersViewModel videoWriterViewmoModel;
        private readonly AudioSourceViewModel audioSourceViewModel;
        private readonly RecordingViewModel recordingViewModel;

        //private readonly ServiceLocator serviceLocator;

        public RecordStreamViewModel(Settings Settings, ILocalizationProvider Loc, 
            VideoSourcesViewModel VideoSourcesViewModel, 
            VideoWritersViewModel VideoWritersViewModel,
            AudioSourceViewModel AudioSourceViewModel,
            RecordingViewModel RecordingViewModel) : base(Settings, Loc)
        {
            //Init();

            //serviceLocator = new ServiceLocator();
            //RecordCommand = serviceLocator.RecordingViewModel.RecordCommand;
            //PauseCommand = serviceLocator.RecordingViewModel.PauseCommand;

            //serviceLocator.VideoSourcesViewModel.SelectedVideoSourceKind =
            //    serviceLocator.VideoSourcesViewModel.VideoSources.FirstOrDefault(M => M is FullScreenSourceProvider);

            //serviceLocator.VideoWritersViewModel.SelectedVideoWriterKind =
            //    serviceLocator.VideoWritersViewModel.VideoWriterProviders.FirstOrDefault(M =>
            //        M is FFmpegWriterProvider);

            //serviceLocator.VideoWritersViewModel.SelectedVideoWriter =
            //    serviceLocator.VideoWritersViewModel.AvailableVideoWriters.FirstOrDefault(M => M is X264VideoCodec);

            //foreach (var availableSpeaker in serviceLocator.AudioSourceViewModel.AvailableSpeakers)
            //{
            //    Console.WriteLine("Speaker name: " + availableSpeaker.Name);
            //}

            //Console.WriteLine("Speaker : " + serviceLocator.AudioSourceViewModel.AvailableSpeakers[1].Name);
            //serviceLocator.RecordingViewModel.Settings.Audio.RecordSpeaker = true;
            //serviceLocator.AudioSourceViewModel.SelectedSpeaker =
            //    serviceLocator.AudioSourceViewModel.AvailableSpeakers[1];


            videoSourceViewModel = VideoSourcesViewModel;
            videoWriterViewmoModel = VideoWritersViewModel;
            audioSourceViewModel = AudioSourceViewModel;
            recordingViewModel = RecordingViewModel;

            RecordCommand = RecordingViewModel.RecordCommand;
            PauseCommand = RecordingViewModel.PauseCommand;

            ConfigDefault();
        }

        public void SetStreamService(string StreamService)
        {
            switch (StreamService)
            {
                case "twitch":
                    videoWriterViewmoModel.SelectedVideoWriter =
                        videoWriterViewmoModel.AvailableVideoWriters.FirstOrDefault(M => M is TwitchVideoCodec);
                    break;
                case "youtube":
                    videoWriterViewmoModel.SelectedVideoWriter =
                        videoWriterViewmoModel.AvailableVideoWriters.FirstOrDefault(M => M is YouTubeLiveVideoCodec);
                    break;
                case "steam":
                    videoWriterViewmoModel.SelectedVideoWriter =
                        videoWriterViewmoModel.AvailableVideoWriters.FirstOrDefault(M => M is SteamLiveVideoCodec);
                    break;
                case "mixer":
                    videoWriterViewmoModel.SelectedVideoWriter =
                        videoWriterViewmoModel.AvailableVideoWriters.FirstOrDefault(M => M is MixerLiveVideoCodec);
                    break;
                case "wowza":
                    videoWriterViewmoModel.SelectedVideoWriter =
                        videoWriterViewmoModel.AvailableVideoWriters.FirstOrDefault(M => M is WowzaLiveVideoCodec);
                    break;
                default:
                    videoWriterViewmoModel.SelectedVideoWriter =
                        videoWriterViewmoModel.AvailableVideoWriters.FirstOrDefault(M => M is X264VideoCodec);
                        break;
            }
        }

        public void StartRecording()
        {
            RecordCommand.Execute(null);
        }

        public void PauseRecording()
        {
            PauseCommand.Execute(null);
        }

        private void Init()
        {
            ServiceProvider.LoadModule(new CoreModule());
            ServiceProvider.LoadModule(new ViewCoreModule());
        }

        private void ConfigDefault()
        {
            videoSourceViewModel.SelectedVideoSourceKind =
                videoSourceViewModel.VideoSources.FirstOrDefault(M => M is FullScreenSourceProvider);
            videoWriterViewmoModel.SelectedVideoWriterKind =
                videoWriterViewmoModel.VideoWriterProviders.FirstOrDefault(M => M is StreamingWriterProvider);
            videoWriterViewmoModel.SelectedVideoWriter =
                videoWriterViewmoModel.AvailableVideoWriters.FirstOrDefault(M => M is X264VideoCodec);

            Settings.Audio.RecordSpeaker = true;
            if (audioSourceViewModel.AvailableSpeakers.Count >= 1)
                audioSourceViewModel.SelectedSpeaker = audioSourceViewModel.AvailableSpeakers[1];

            Settings.FFmpeg.Resize = false;
        }
    }
}
