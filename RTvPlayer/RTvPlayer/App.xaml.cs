using RTvPlayer.Views;
using Xamarin.Forms;

namespace RTvPlayer
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            MainPage = new RTvCanales(); //RadioTelevisionCanales(); //IberoamericaRadio(); //CanalIberoamericano(); //RTvCanales();
            //MainPage = new NavigationPage(new RadioTelevisionCanales());
            //NavigationPage.SetHasNavigationBar(MainPage, false);
        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
