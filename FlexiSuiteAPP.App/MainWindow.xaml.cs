using FlexiSuiteAPP.App.Views;
using System.Windows;

namespace FlexiSuiteAPP.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnNavigateButtonClick(object sender, RoutedEventArgs e)
        {
            // Tạo một instance của EmptyView
            var emptyView = new EmptyView();

            // Xóa bỏ các phần tử hiện tại trong MainGrid và thêm EmptyView
            MainGrid.Children.Clear();
            MainGrid.Children.Add(emptyView);
        }
    }
}
