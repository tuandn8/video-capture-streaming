using Captura.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Captura.FFmpeg
{
    public class SteamLiveVideoCodec : StreamingVideoCodec
    {
        public SteamLiveVideoCodec() : base("Steam Live", "Stream to Steam Live") { }

        public override void Apply(FFmpegSettings Settings, VideoWriterArgs WriterArgs, FFmpegOutputArgs OutputArgs)
        {
            var x264 = new X264VideoCodec();

            x264.Apply(Settings, WriterArgs, OutputArgs);

            OutputArgs.AddArg("g", WriterArgs.FrameRate * 2)
                .AddArg("maxrate", "4500k")
                .AddArg("b:v", "4500k")
                .AddArg("bufsize", "5M")
                //.AddArg("r", WriterArgs.FrameRate)
                .AddArg("f", "flv");

            var link = GetLink(Settings);

            WriterArgs.FileName = link;
            OutputArgs.UpdateOutput(link);
        }

        protected override string GetLink(FFmpegSettings Settings)
        {
            return $"{Settings.SteamLiveUrl}/{Settings.SteamLiveKey}";
        }

    }
}
