using Plugin.SharedTransitions;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("NunitoSans-Bold.ttf", Alias ="Themeboldfont")]
[assembly: ExportFont("NunitoSans-Regular.ttf", Alias = "Themeregularfont")]
[assembly: ExportFont("NunitoSans-SemiBold.ttf", Alias = "Themesemiboldfont")]
namespace WogiaHomes
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SharedTransitionNavigationPage(new MainPage());
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
