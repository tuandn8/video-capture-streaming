using System;
using System.Collections.Generic;
using System.Text;

namespace Captura.FFmpeg
{
    public class SteamLiveVideoCodec : StreamingVideoCodec
    {
        public SteamLiveVideoCodec() : base("Steam Live", "Stream to Steam Live") { }

        protected override string GetLink(FFmpegSettings Settings)
        {
            return $"{Settings.SteamLiveUrl}/{Settings.SteamLiveKey}";
        }

    }
}
