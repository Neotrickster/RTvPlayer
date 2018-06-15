using System;
using System.Collections.Generic;
using System.Text;
using ILCE.ViewModels;

namespace RTvPlayer.ViewModels
{
    class CanalIberoamericanoViewModel : BaseViewModel
    {
        public int screenSizeHeight { get; set; }

        public CanalIberoamericanoViewModel()
        {
            Title = "Canal Iberoamericano";

            var size = Plugin.XamJam.Screen.CrossScreen.Current.Size;
            screenSizeHeight = (int)((size.Height - 270) / 4);
        }
    }
}
