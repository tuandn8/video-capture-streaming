using System;
using System.Collections.Generic;
using System.Text;

namespace Captura.FFmpeg
{
    public class MixerLiveVideoCodec : StreamingVideoCodec
    {
        public MixerLiveVideoCodec() : base("Mixer Live", "Stream to Mixer Live") { }

        protected override string GetLink(FFmpegSettings Settings)
        {
            return $"{Settings.SteamLiveUrl}/{Settings.MixerLiveKey}";
        }

    }
}
