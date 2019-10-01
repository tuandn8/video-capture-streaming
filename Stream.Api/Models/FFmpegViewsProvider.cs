using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Captura;
using Captura.FFmpeg;
using Captura.Models;

namespace Stream.Api.Models
{
    public class FFmpegViewsProvider : IFFmpegViewsProvider
    {
        readonly ILocalizationProvider _loc;
        readonly IAudioPlayer _audioPlayer;
        readonly FFmpegSettings _settings;
        readonly IDialogService _dialogService;

        public FFmpegViewsProvider(ILocalizationProvider Loc,
            IAudioPlayer AudioPlayer,
            FFmpegSettings Settings,
            IDialogService DialogService)
        {
            this._loc = Loc;
            this._audioPlayer = AudioPlayer;
            this._settings = Settings;
            this._dialogService = DialogService;
        }
        public void ShowLogs()
        {
            
        }

        public void ShowUnavailable()
        {
            
        }

        public void ShowDownloader()
        {
            
        }

        public void PickFolder()
        {
            var folder = _dialogService.PickFolder(_settings.GetFolderPath(), _loc.SelectFFmpegFolder);

            if (!string.IsNullOrWhiteSpace(folder))
                _settings.FolderPath = folder;
        }
    }
}
