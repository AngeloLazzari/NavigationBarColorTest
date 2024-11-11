
using Microsoft.Maui.Controls;
using Prism.Navigation;
using System.Diagnostics;
using TestPrism.Views;

namespace TestPrism.ViewModels;

public class Page3ViewModel : BindableBase, INavigationAware
{

    private INavigationService _navigationService;



    public Page3ViewModel(INavigationService navigationService)
    {
        _navigationService = navigationService;

        InitApp();
        
    }

    private async void InitApp()
    {
        // QUESTA FUNZIONA
        //var navResult = await _navigationService.NavigateAsync("/" + nameof(MenuIniziale) + "/" + nameof(NavigationPage) + "/" + nameof(PaginaIniziale));
        //var navResult = await _navigationService.NavigateAsync("/MenuIniziale/NavigationPage/PaginaIniziale");


        // var navResult = await _navigationService.NavigateAsync("/" + nameof(MenuIniziale));

    }



    public void OnNavigatedFrom(INavigationParameters parameters)
    {
    }

    public void OnNavigatedTo(INavigationParameters parameters)
    {
    }
}