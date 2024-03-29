﻿using System;

namespace Captura.Models
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class FakeSystemTray : ISystemTray
    {
        readonly ILocalizationProvider _loc;

        public FakeSystemTray(ILocalizationProvider Loc)
        {
            _loc = Loc;
        }

        public void HideNotification() { }

        public void ShowScreenShotNotification(string FilePath)
        {
            // ReSharper disable once LocalizableElement
            Console.WriteLine($"{_loc.ScreenShotSaved}: {FilePath}");
        }

        public void ShowNotification(INotification Notification) { }
    }
}
