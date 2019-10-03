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
            _recordStreamViewModel.Settings.FFmpeg.YouTubeLiveKey = "t8p8-f29d-tumt-2cq1";
            _recordStreamViewModel.StartRecording();
        }

        private void btnStopStreamYoutube_Click(object sender, EventArgs e)
        {
            _recordStreamViewModel.PauseRecording();
        }

        private void btnStartSteam_Click(object sender, EventArgs e)
        {
            _recordStreamViewModel.SetStreamService("steam");
            _recordStreamViewModel.Settings.FFmpeg.SteamLiveUrl =
                "rtmp://ingest-02-hkg1.broadcast.steamcontent.com/app";
            _recordStreamViewModel.Settings.FFmpeg.SteamLiveKey = "steam_294584987_366a0a71f6fe1953";
            _recordStreamViewModel.StartRecording();
        }

        private void btnStopSteam_Click(object sender, EventArgs e)
        {
            _recordStreamViewModel.PauseRecording();
        }

        private void btnStartMixer_Click(object sender, EventArgs e)
        {

        }

        private void btnStopMixer_Click(object sender, EventArgs e)
        {

        }

        private void btnStartWowza_Click(object sender, EventArgs e)
        {
            _recordStreamViewModel.SetStreamService("wowza");
            _recordStreamViewModel.Settings.FFmpeg.WowzaLiveUrl = "rtmp://192.168.1.16:1935";
            _recordStreamViewModel.Settings.FFmpeg.WowzaApp = "live";
            _recordStreamViewModel.Settings.FFmpeg.WowzaStream = "myStream";
            
            _recordStreamViewModel.StartRecording();
        }

        private void btnStopWowza_Click(object sender, EventArgs e)
        {
            _recordStreamViewModel.PauseRecording();
        }
    }
}
