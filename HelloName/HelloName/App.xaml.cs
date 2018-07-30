using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace HelloName
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new HomePage();
		}

		protected override void OnStart ()
		{
            // Handle when your app starts
            Analytics.SetEnabledAsync(true);

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
