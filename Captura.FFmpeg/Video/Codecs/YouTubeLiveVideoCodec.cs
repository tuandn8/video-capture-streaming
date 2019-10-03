namespace Captura.FFmpeg
{
    public class YouTubeLiveVideoCodec : StreamingVideoCodec
    {
        public YouTubeLiveVideoCodec() : base("YouTube Live", "Stream to YouTube Live") { }

        protected override string GetLink(FFmpegSettings Settings)
        {
            return $"rtmp://a.rtmp.youtube.com/live2/{Settings.YouTubeLiveKey}";
        }
    }
}