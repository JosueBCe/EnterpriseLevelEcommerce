using eShopOnContainers.Services.Settings;

namespace eShopOnContainers.Services;

public class MauiNavigationService : INavigationService
{
    private readonly ISettingsService _settingsService;

    public MauiNavigationService(ISettingsService settingsService)
    {
        _settingsService = settingsService;
    }

    public Task InitializeAsync() =>
        NavigateToAsync(
            string.IsNullOrEmpty(_settingsService.AuthAccessToken)
                ? "//Login"
                : "//Main/Catalog");

    public Task NavigateToAsync(string route, IDictionary<string, object> routeParameters = null)
    {
        var shellNavigation = new ShellNavigationState(route);

        return routeParameters != null
            // If there's something in the route parameters, consider them to navigate
            ? Shell.Current.GoToAsync(shellNavigation, routeParameters)
            // else navigate to the specified route (that it doesn't have parameters) 
            : Shell.Current.GoToAsync(shellNavigation);
    }

    public Task PopAsync() =>
        Shell.Current.GoToAsync("..");
}