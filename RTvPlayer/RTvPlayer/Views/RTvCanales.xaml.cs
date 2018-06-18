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
	public partial class RTvCanales : ContentPage
	{
		public RTvCanales ()
		{
			InitializeComponent ();

		    BindingContext = new RTvCanalesViewModel();
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

        private void PlayCIAButton_OnClicked(object sender, EventArgs e)
	    {
	        VideoPlayer.Source = "http://apreal04.triara.com:1935/redirect/canaliberoamericano1/live.mp4?scheme=m3u8";
            VideoPlayer.Stop();
	        VideoPlayer.Play();
	        VideoPlayer.Opacity = 1;
            Canal.Text = "Canal Iberoamericano";
	    }

	    private void PlayCSSButton_OnClicked(object sender, EventArgs e)
	    {
	        VideoPlayer.Source = "http://apreal04.triara.com:1935/redirect/ilcea/live.mp4?scheme=m3u8";
	        VideoPlayer.Stop();
            VideoPlayer.Play();
	        VideoPlayer.Opacity = 1;
            Canal.Text = "Summa Saberes";
	    }

	    private void PlayCIRButton_OnClicked(object sender, EventArgs e)
	    {
	        VideoPlayer.Source = "http://201.159.130.34:8080/radioilce.mp3";
	        VideoPlayer.Stop();
            VideoPlayer.Play();
	        VideoPlayer.Opacity = 0.5;
	        Canal.Text = "Iberoamerica Radio";
	    }
    }
}