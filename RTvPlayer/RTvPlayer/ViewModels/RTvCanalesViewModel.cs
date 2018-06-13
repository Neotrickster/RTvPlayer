using ILCE.ViewModels;

namespace RTvPlayer.ViewModels
{
    class RTvCanalesViewModel : BaseViewModel
    {
        public int screenSizeHeight { get; set; }

        public RTvCanalesViewModel()
        {
            Title = "ILCE RTv";

            var size = Plugin.XamJam.Screen.CrossScreen.Current.Size;
            screenSizeHeight = (int)((size.Height - 270) / 4);
        }
    }
}
