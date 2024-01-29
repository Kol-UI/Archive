using System;
namespace MauiApp1.Services.Navigation
{
    public interface INavigationService
    {
        Task InitializeAsync();

        Task NavigateToAsync(string route, IDictionary<string, object> routeParameters = null);

        Task NavigateToPageAsync(Page page);

        Task PopAsync();
    }
}

