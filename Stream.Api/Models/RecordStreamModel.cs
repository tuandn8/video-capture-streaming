using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Captura;
using Captura.Models;
using Captura.ViewModels;
using Captura.FFmpeg;

namespace Stream.Api.Models
{
    public class RecordStreamModel
    {
        public ICommand RecordCommand { get; set; }
        public ICommand PauseCommand { get; set; }

        private ServiceLocator serviceLocator;
        
        public RecordStreamModel()
        {
            Init();

            serviceLocator = new ServiceLocator();
            RecordCommand = serviceLocator.RecordingViewModel.RecordCommand;
            PauseCommand = serviceLocator.RecordingViewModel.PauseCommand;

            serviceLocator.VideoSourcesViewModel.SelectedVideoSourceKind =
                serviceLocator.VideoSourcesViewModel.VideoSources.FirstOrDefault(M => M is FullScreenSourceProvider);

            serviceLocator.VideoWritersViewModel.SelectedVideoWriterKind =
                serviceLocator.VideoWritersViewModel.VideoWriterProviders.FirstOrDefault(M =>
                    M is FFmpegWriterProvider);

            serviceLocator.VideoWritersViewModel.SelectedVideoWriter =
                serviceLocator.VideoWritersViewModel.AvailableVideoWriters.FirstOrDefault(M => M is X264VideoCodec);

            serviceLocator.AudioSourceViewModel.SelectedSpeaker =
                serviceLocator.AudioSourceViewModel.AvailableSpeakers.FirstOrDefault();

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

    }
}
