using System;
using Microsoft.Maui.Controls;
using System.Threading.Tasks;

namespace MauiApp1.Services.Navigation
{
	public class MauiNavigationService : INavigationService
    {
        public MauiNavigationService()
        {
        }

        public Task InitializeAsync() => NavigateToAsync("//MainPage");

        public Task NavigateToAsync(string route, IDictionary<string, object> routeParameters = null)
        {
            var shellNavigation = new ShellNavigationState(route);

            return routeParameters != null
                ? Shell.Current.GoToAsync(shellNavigation, routeParameters)
                : Shell.Current.GoToAsync(shellNavigation);
        }

        public Task PopAsync() => Shell.Current.GoToAsync("..");


        public async Task NavigateToPageAsync(Page page)
        {
            var navigationPage = Application.Current.MainPage as NavigationPage;
            if (navigationPage != null)
            {
                await navigationPage.PushAsync(page);
            }
        }
    }
}

