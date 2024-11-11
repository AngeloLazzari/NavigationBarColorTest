
using Prism.Navigation;
using System.Diagnostics;
using TestPrism.Views;

namespace TestPrism.ViewModels;

public class MenuInizialeViewModel : BindableBase
{
    private INavigationService _navigationService;

    public DelegateCommand ApriPaginaInizizale { get; private set; }
    public DelegateCommand ApriPagina2 { get; private set; }

    public DelegateCommand ApriPagina3 { get; private set; }



    public MenuInizialeViewModel(INavigationService navigationService)
	{
        _navigationService = navigationService;

        ApriPaginaInizizale = new DelegateCommand(async () => await _navigationService.NavigateAsync("/MenuIniziale/NavigationPage/PaginaIniziale"));
        ApriPagina2 = new DelegateCommand(async () => await _navigationService.NavigateAsync(nameof(NavigationPage) + "/" + nameof(Page2)));
        ApriPagina3 = new DelegateCommand(async () => await _navigationService.NavigateAsync(nameof(NavigationPage) + "/" + nameof(Page3)));




        //InitApp();

    }


    private async void InitApp()
    {
        // QUESTA FUNZIONA
        var navResult = await _navigationService.NavigateAsync("/" + nameof(MenuIniziale) + "/" + nameof(NavigationPage) + "/" + nameof(PaginaIniziale));

        //var navResult = await _navigationService.NavigateAsync("/" + nameof(MenuIniziale));

    }

}