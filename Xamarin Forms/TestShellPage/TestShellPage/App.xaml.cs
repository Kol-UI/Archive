using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TabbedPages.Services;
using TabbedPages.Views;

[assembly: ExportFont("MaterialIconsRegular.ttf", Alias = "Material")]
namespace TabbedPages
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
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
