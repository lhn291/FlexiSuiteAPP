using FlexiSuiteAPP.App.ViewModels;
using FlexiSuiteAPP.App.Views;

namespace FlexiSuiteAPP.App
{
    public static class Configurator
    {
        public static void Configure()
        {
            // Đăng ký các view và viewmodel
            RegisterViewsAndViewModels();
        }

        private static void RegisterViewsAndViewModels()
        {
            // Đăng ký các view và viewmodel ở đây
            ServiceProvider.Instance.RegisterService(typeof(EmptyView), typeof(EmptyViewModel));
            // Đăng ký các view và viewmodel khác nếu cần
        }
    }
}
