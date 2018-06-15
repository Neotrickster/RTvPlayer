using System;
using System.Collections.Generic;
using System.Text;
using ILCE.ViewModels;

namespace RTvPlayer.ViewModels
{
    class RadioTelevisionCanalesViewModel : BaseViewModel
    {
        public int screenSizeHeight { get; set; }

        public RadioTelevisionCanalesViewModel()
        {
            Title = "ILCE - Radio y Televisión";

            var size = Plugin.XamJam.Screen.CrossScreen.Current.Size;
            screenSizeHeight = (int)((size.Height - 50) / 4);
        }
    }
}
