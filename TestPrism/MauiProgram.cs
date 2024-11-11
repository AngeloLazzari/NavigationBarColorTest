using Microsoft.Extensions.Logging;
using Prism.Ioc;
using System.Diagnostics;
using TestPrism.ViewModels;
using TestPrism.Views;

namespace TestPrism
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder
                .UseMauiApp<App>()


                .UsePrism(prism =>

                    prism.RegisterTypes(containerRegistry =>
                        {
                            containerRegistry.RegisterForNavigation<InizializzaApp, InizializzaAppViewModel>();
                            containerRegistry.RegisterForNavigation<MenuIniziale, MenuInizialeViewModel>();
                            containerRegistry.RegisterForNavigation<PaginaIniziale, PaginaInizialeViewModel>();
                            containerRegistry.RegisterForNavigation<Page3, Page3ViewModel>();
                            containerRegistry.RegisterForNavigation<Page2, Page2ViewModel>();
                        }
                    )

                    
                    .CreateWindow(async (container, navigation) =>
                    {

                        // var result = await navigation.NavigateAsync("/" + nameof(InizializzaApp));
                        var result = await navigation.NavigateAsync("/InizializzaApp");

                        if (result.Success == false) { Debugger.Break(); }

                                
                            
                    })

                    
                    
                )


                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
