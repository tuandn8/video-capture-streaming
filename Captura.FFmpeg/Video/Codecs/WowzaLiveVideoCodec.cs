using Captura.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Captura.FFmpeg
{
    public class WowzaLiveVideoCodec : StreamingVideoCodec
    {
        public WowzaLiveVideoCodec() : base("Wowza Live", "Stream to Wowza Live")
        {
        }

        public override void Apply(FFmpegSettings Settings, VideoWriterArgs WriterArgs, FFmpegOutputArgs OutputArgs)
        {
            // quality: 51 (lowest) to 0 (highest)
            var crf = (51 * (100 - WriterArgs.VideoQuality)) / 99;

            OutputArgs.AddArg("crf", crf)
                .AddArg("pix_fmt", Settings.X264.PixelFormat)
                .AddArg("preset", Settings.X264.Preset);

            OutputArgs.AddArg("g", WriterArgs.FrameRate * 2)
                .AddArg("r", WriterArgs.FrameRate)
                .AddArg("f", "flv");

            var link = GetLink(Settings);

            WriterArgs.FileName = link;
            OutputArgs.UpdateOutput(link);
        }

        protected override string GetLink(FFmpegSettings Settings)
        {
            return $"{Settings.WowzaLiveUrl}/{Settings.WowzaApp}/{Settings.WowzaStream}";
        }
    }
}
