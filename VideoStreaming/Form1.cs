using System;
using System.Windows.Forms;
using Captura;
using Captura.ViewModels;
using RecordStreamApi.Authentication;
using RecordStreamApi.Authentication.Impl.Youtube;
using RecordStreamApi.Models;
using RecordStreamApi.StreamService.Impl.Youtube;
using Settings = VideoStreaming.Properties.Settings;


namespace VideoStreaming
{
    public partial class Form1 : Form
    {
        private readonly Settings settings;
        private RecordStreamViewModel _recordStreamViewModel;

        private readonly ServiceLocator serviceLocator;
        public Form1()
        {
            InitializeComponent();

            ServiceProvider.LoadModule(new CoreModule());
            ServiceProvider.LoadModule(new ViewCoreModule());

            serviceLocator = new ServiceLocator();
            _recordStreamViewModel = serviceLocator.RecordStreamViewModel;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            _recordStreamViewModel.SetStreamService("twitch");
            _recordStreamViewModel.Settings.FFmpeg.TwitchKey = "live_32096828_qv2sAThZI25nbTgzxXSNTnxYK9b8oH";
            _recordStreamViewModel.StartRecording();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _recordStreamViewModel.PauseRecording();
        }

        private void btnLoginYoutube_Click(object sender, EventArgs e)
        {
            IStreamingServiceAuthentication authen = new YoutubeServiceAuthentication();
            if (authen.Authenticate("client_secret.json"))
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }

        private void btnStreamYoutube_Click(object sender, EventArgs e)
        {
            
            //YoutubeStreamService youtubeStreamService = new YoutubeStreamService();
            //var streamKey = youtubeStreamService.GetStreamKey();
            //streamKey.Wait();

            //_recordStreamViewModel.Settings.FFmpeg.YouTubeLiveKey = streamKey.Result;
            _recordStreamViewModel.SetStreamService("youtube");
            _recordStreamViewModel.Settings.FFmpeg.YouTubeLiveKey = txtYoutubeKey.Text;
            _recordStreamViewModel.StartRecording();
        }

        private void btnStopStreamYoutube_Click(object sender, EventArgs e)
        {
            _recordStreamViewModel.PauseRecording();
        }

        private void btnStartSteam_Click(object sender, EventArgs e)
        {
            _recordStreamViewModel.SetStreamService("steam");
            _recordStreamViewModel.Settings.FFmpeg.SteamLiveUrl = txtSteamUrl.Text;
            _recordStreamViewModel.Settings.FFmpeg.SteamLiveKey = txtSteamKey.Text;
            _recordStreamViewModel.StartRecording();
        }

        private void btnStopSteam_Click(object sender, EventArgs e)
        {
            _recordStreamViewModel.PauseRecording();
        }

        private void btnStartMixer_Click(object sender, EventArgs e)
        {
            _recordStreamViewModel.SetStreamService("mixer");
            _recordStreamViewModel.Settings.FFmpeg.MixerLiveUrl = txtMixerUrl.Text;
            _recordStreamViewModel.Settings.FFmpeg.MixerLiveKey = txtMixerKey.Text;
            _recordStreamViewModel.StartRecording();
        }

        private void btnStopMixer_Click(object sender, EventArgs e)
        {
            _recordStreamViewModel.PauseRecording();
        }

        private void btnStartWowza_Click(object sender, EventArgs e)
        {
            _recordStreamViewModel.SetStreamService("wowza");
            _recordStreamViewModel.Settings.FFmpeg.WowzaLiveUrl = txtWowzaUrl.Text;
            
            _recordStreamViewModel.StartRecording();
        }

        private void btnStopWowza_Click(object sender, EventArgs e)
        {
            _recordStreamViewModel.PauseRecording();
        }
    }
}
