using System;
using System.Collections.Generic;
using System.Text;
using ILCE.ViewModels;

namespace RTvPlayer.ViewModels
{
    class SummaSaberesViewModel : BaseViewModel
    {
        public int screenSizeHeight { get; set; }

        public SummaSaberesViewModel()
        {
            Title = "Summa Saberes";

            var size = Plugin.XamJam.Screen.CrossScreen.Current.Size;
            screenSizeHeight = (int)((size.Height - 270) / 4);
        }
    }
}
