using Captura.Models;

namespace Captura.FFmpeg
{
    public class YouTubeLiveVideoCodec : StreamingVideoCodec
    {
        public YouTubeLiveVideoCodec() : base("YouTube Live", "Stream to YouTube Live") { }

        public override void Apply(FFmpegSettings Settings, VideoWriterArgs WriterArgs, FFmpegOutputArgs OutputArgs)
        {
            var x264 = new X264VideoCodec();

            x264.Apply(Settings, WriterArgs, OutputArgs);

            OutputArgs.AddArg("g", WriterArgs.FrameRate * 2)
                .AddArg("maxrate", "5000k")
                .AddArg("bitrate", "5000k")
                .AddArg("bufsize", "10M")
                //.AddArg("r", WriterArgs.FrameRate)
                .AddArg("f", "flv");

            var link = GetLink(Settings);

            WriterArgs.FileName = link;
            OutputArgs.UpdateOutput(link);
        }

        protected override string GetLink(FFmpegSettings Settings)
        {
            return $"rtmp://a.rtmp.youtube.com/live2/{Settings.YouTubeLiveKey}";
        }
    }
}