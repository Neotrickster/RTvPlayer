using System;
using System.Collections.Generic;
using System.Text;
using ILCE.ViewModels;

namespace RTvPlayer.ViewModels
{
    class IberoamericaRadioViewModel : BaseViewModel
    {
        public int screenSizeHeight { get; set; }

        public IberoamericaRadioViewModel()
        {
            Title = "Iberoamerica Radio";

            var size = Plugin.XamJam.Screen.CrossScreen.Current.Size;
            screenSizeHeight = (int)((size.Height - 270) / 3);
        }
    }
}
