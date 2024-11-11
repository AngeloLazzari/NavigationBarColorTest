

namespace TestPrism.ViewModels;

public class PaginaInizialeViewModel : BindableBase, INavigationAware
{
	public PaginaInizialeViewModel()
	{
		
	}

    public void OnNavigatedFrom(INavigationParameters parameters)
    {
       
    }

    public void OnNavigatedTo(INavigationParameters parameters)
    {
        Console.WriteLine("On Navigate To of ViewC");
    }
}