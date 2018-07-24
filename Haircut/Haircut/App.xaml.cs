using Haircut.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Haircut
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			//FIXME : cehck if user is loggedIn go to App directly
			if (Device.RuntimePlatform == Device.iOS)
				MainPage = new LoginPage();
			else
				MainPage = new NavigationPage(new LoginPage());
		}
	}
}