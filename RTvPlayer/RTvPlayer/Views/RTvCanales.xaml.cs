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

	    private void PlayCIAButton_OnClicked(object sender, EventArgs e)
	    {
	        VideoPlayer.Source = "http://apreal04.triara.com:1935/redirect/ilcea/live.mp4?scheme=m3u8";
            VideoPlayer.Stop();
	        VideoPlayer.Play();
	        VideoPlayer.Opacity = 1;
            Canal.Text = "Canal Iberoamericano";
	    }

	    private void PlayCSSButton_OnClicked(object sender, EventArgs e)
	    {
	        VideoPlayer.Source = "http://apreal04.triara.com:1935/redirect/canaliberoamericano1/live.mp4?scheme=m3u8";
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