using System.Collections.Generic;
using NAudio.CoreAudioApi;

namespace Captura.Audio
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class NAudioSource : IAudioSource
    {
        public string Name { get; } = "NAudio";

        public IEnumerable<IAudioItem> Microphones
        {
            get
            {
                var enumerator = new MMDeviceEnumerator();
                var devices = enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active);
                //enumerator.Dispose();
                foreach (var device in devices)
                {
                    yield return new NAudioItem(device, false);
                }
            }
        }

        public IAudioItem DefaultMicrophone => NAudioDefaultItem.DefaultMicrophone;

        public IEnumerable<IAudioItem> Speakers
        {
            get
            {
                var enumerator = new MMDeviceEnumerator();
                var devices = enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active);
                enumerator.Dispose();

                foreach (var device in devices)
                {
                    yield return new NAudioItem(device, true);
                }
            }
        }

        public IAudioItem DefaultSpeaker => NAudioDefaultItem.DefaultSpeaker;

        public void Dispose() { }

        public IAudioProvider GetAudioProvider(IAudioItem Microphone, IAudioItem Speaker)
        {
            if (Microphone == null)
            {
                if (Speaker != null)
                {
                    NAudioItem speaker = (NAudioItem)Speaker;
                    return new MixedAudioProvider(new WasapiLoopbackCaptureProvider(speaker.Device));
                }
            } else
            {
                NAudioItem mic = (NAudioItem)Microphone;
                if (Speaker == null)
                {
                    return new MixedAudioProvider(new WasapiCaptureProvider(mic.Device));
                } else
                {
                    NAudioItem speaker = (NAudioItem)Speaker;
                    return new MixedAudioProvider(
                        new WasapiCaptureProvider(mic.Device),
                        new WasapiLoopbackCaptureProvider(speaker.Device));
                }
            }

            return null;
        }
    }
}
