using Plugin.Toasts;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Haircut.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();
		}

		public Task<bool> ToastNotificationType { get; private set; }

		async void Login_Clicked(object sender, EventArgs e)
		{
			if (email.Text == "a" && password.Text == "a")
			{
				Application.Current.MainPage = new NavigationPage(new MainPage());
			}
			else
			{

			}
		}
		async void Register_Clicked(object sender, EventArgs e)
		{
			ShowToast(new NotificationOptions()
			{
				Title = "The Title Line",
				Description = "The Description Content",
				IsClickable = false,
				DelayUntil = DateTime.Now + TimeSpan.FromSeconds(2)
				//WindowsOptions = new WindowsOptions() { LogoUri = "icon.png" },
				//ClearFromHistory = false,
				//AllowTapInNotificationCenter = false,
				//AndroidOptions = new AndroidOptions()
				//{
				//	HexColor = "#F99D1C",
				//	ForceOpenAppOnNotificationTap = true
				//}
			});
		}

		async void ShowToast(INotificationOptions options)
		{
			await Navigation.PushAsync(new RegisterPage());
			//var notificator = DependencyService.Get<IToastNotificator>();
			//await notificator.Notify(options);
			//notificator.Notify((INotificationResult result) =>
			//{
			//	System.Diagnostics.Debug.WriteLine("Notification [" + result.Id + "] Result Action: " + result.Action);
			//}, options);
		}
	}
}