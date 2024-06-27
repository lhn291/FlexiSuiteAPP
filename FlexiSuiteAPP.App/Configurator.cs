using FlexiSuiteAPP.App.Services;
using FlexiSuiteAPP.App.Views;
using FlexiSuiteAPP.App.ViewModels;
using FlexiSuiteAPP.App.Views.Popups;
using FlexiSuiteAPP.App.ViewModels.Popups;

namespace FlexiSuiteAPP.App
{
    public static class Configurator
    {
        public static NavigationService? NavigationService { get; private set; }

        public static void Configure()
        {
            NavigationService = new NavigationService();

            NavigationService.RegisterView("EmptyView", typeof(EmptyView), typeof(EmptyViewModel));

            NavigationService.RegisterPopup("CustomPopup", typeof(CustomPopup), typeof(CustomPopupViewModel));
        }
    }
}
