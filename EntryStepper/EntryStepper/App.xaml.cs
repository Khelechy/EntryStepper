using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


[assembly: ExportFont("montserrat.bold.ttf", Alias = "fontbold")]
[assembly: ExportFont("montserrat.regular.ttf", Alias = "fontdefault")]
namespace EntryStepper
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new MainPage();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
