using FlexiSuiteAPP.App.Services;
using System.Windows;

namespace FlexiSuiteAPP.App
{
    public partial class MainWindow : Window
    {
        private readonly NavigationService _navigationService;

        public MainWindow()
        {
            InitializeComponent();
            _navigationService = Configurator.NavigationService!;
        }

        private void OnNavigateButtonClick(object sender, RoutedEventArgs e)
        {
            _navigationService.NavigateTo("EmptyView", MainContent);
        }

        private void OnShowPopupButtonClick(object sender, RoutedEventArgs e)
        {
            _navigationService.ShowPopup("CustomPopup");
        }
    }
}
