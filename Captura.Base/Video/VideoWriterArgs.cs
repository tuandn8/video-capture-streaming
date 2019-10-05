using Captura.Audio;

namespace Captura.Models
{
    public class VideoWriterArgs
    {
        public string FileName { get; set; }
        public IImageProvider ImageProvider { get; set; }
        public int FrameRate { get; set; } = 30;
        public int VideoQuality { get; set; } = 70;
        public int AudioQuality { get; set; } = 25;
        public IAudioProvider AudioProvider { get; set; }
    }
}