﻿namespace Captura.Models
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class FakeWindowProvider : IMainWindow
    {
        public bool IsVisible
        {
            get => true;
            set { }
        }

        public bool IsMinimized
        {
            get => false;
            set { }
        }

        public void EditImage(string FileName) { }

        public void CropImage(string FileName) { }

        public void TrimMedia(string FileName) { }

        public void UploadToYouTube(string FileName) { }
    }
}
