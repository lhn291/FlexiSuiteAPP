using System.Windows;
using System.Windows.Controls;

namespace FlexiSuiteAPP.App.Services
{
    public class NavigationService
    {
        private readonly Dictionary<string, Type> _views = new Dictionary<string, Type>();
        private readonly Dictionary<string, Type> _popups = new Dictionary<string, Type>();
        private readonly Dictionary<Type, Type> _viewModels = new Dictionary<Type, Type>();

        public void RegisterView(string name, Type viewType, Type viewModelType)
        {
            _views[name] = viewType;
            _viewModels[viewType] = viewModelType;
        }

        public void RegisterPopup(string name, Type popupType, Type viewModelType)
        {
            _popups[name] = popupType;
            _viewModels[popupType] = viewModelType;
        }

        public void NavigateTo(string viewName, ContentControl contentControl)
        {
            if (_views.TryGetValue(viewName, out var viewType))
            {
                var view = (UserControl)Activator.CreateInstance(viewType)!;
                var viewModelType = _viewModels[viewType];
                var viewModel = Activator.CreateInstance(viewModelType);
                view.DataContext = viewModel;
                contentControl.Content = view;
            }
            else
            {
                throw new KeyNotFoundException($"View '{viewName}' not found.");
            }
        }

        public void ShowPopup(string popupName)
        {
            if (_popups.TryGetValue(popupName, out var popupType))
            {
                var popup = (Window)Activator.CreateInstance(popupType)!;
                var viewModelType = _viewModels[popupType];
                var viewModel = Activator.CreateInstance(viewModelType);
                popup.DataContext = viewModel;
                popup.ShowDialog();
            }
            else
            {
                throw new KeyNotFoundException($"Popup '{popupName}' not found.");
            }
        }
    }
}
