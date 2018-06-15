using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RTvPlayer.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RTvPlayer.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IberoamericaRadio : ContentPage
	{
		public IberoamericaRadio ()
		{
			InitializeComponent ();
		    BindingContext = new IberoamericaRadioViewModel();

		    AudioPlayerIR.FullScreenStatusChanged += VideoPlayer_FullScreenStatusChanged;
        }

        private void VideoPlayer_FullScreenStatusChanged(object sender, bool value)
        {
            NavigationPage.SetHasNavigationBar(this, !value);
        }

        private double _width = 0;
        private double _height = 0;

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height); //must be called
            if (this._width != width || this._height != height)
            {
                this._width = width;
                this._height = height;
                //reconfigurar layout cuando se gira el teléfono
                if (width > height)
                {
                    //outerStack.Orientation = StackOrientation.Horizontal;
                    //outterScroll.IsVisible = true;
                    innerStack.IsVisible = false;
                    outerStack.BackgroundColor = Color.Black;
                    //this.BackgroundColor = Color.Aqua;
                    //innerGrid.IsVisible = false;
                    //Canal.IsVisible = false;
                    //VideoPlayer.
                    //InvalidateMeasure();
                }
                else
                {
                    //outerStack.Orientation = StackOrientation.Vertical;
                    //outterScroll.IsVisible = false;
                    innerStack.IsVisible = true;
                    outerStack.BackgroundColor = Color.White;
                    //this.BackgroundColor = Color.Chartreuse;
                    //innerGrid.IsVisible = true;
                    //Canal.IsVisible = true;
                    //Canal.Text = Canal.Text + "(" + this._width + ")" + "(" + this._height + ")";
                    //InvalidateMeasure();
                }
            }
        }

        private async Task BtnPlayCI_OnClicked(object sender, EventArgs e)
        {
            AudioPlayerIR.Stop();
            //VideoPlayerCI.IsVisible = false;
            //await this.Navigation.PushAsync(new RTvCanales());
            //await this.Navigation.PushModalAsync(new RTvCanales());
            App.Current.MainPage = new CanalIberoamericano();
            //App.Current.MainPage = new NavigationPage(new RTvCanales());
        }

        private async Task BtnPlaySS_OnClicked(object sender, EventArgs e)
        {
            AudioPlayerIR.Stop();
            //VideoPlayerCI.IsVisible = false;
            //await this.Navigation.PushAsync(new RTvCanales());
            //await this.Navigation.PushModalAsync(new RTvCanales());
            App.Current.MainPage = new SummaSaberes();
            //App.Current.MainPage = new NavigationPage(new RTvCanales());
        }
    }
}