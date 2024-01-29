using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ListView.Services;
using ListView.Views;


[assembly: ExportFont("Dark_College.otf", Alias = "DarkCollegeFont")]
[assembly: ExportFont("The_Snowday.ttf", Alias = "TheSnowdayFont")]
[assembly: ExportFont("Metropolis-Regular.otf", Alias = "MetropolisRegularFont")]
[assembly: ExportFont("CamptonBook.otf", Alias = "CamptonBookFont")]

namespace ListView
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            Sharpnado.Shades.Initializer.Initialize(loggerEnable: false);
            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
