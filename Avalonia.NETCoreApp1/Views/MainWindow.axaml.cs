using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.NETCoreApp1.ViewModels;

namespace Avalonia.NETCoreApp1.Views
{
    public partial class MainWindow : Window
    {
        private readonly MainWindowViewModel _mainWindowViewModel;

        public MainWindow()
        {
            InitializeComponent();
            System.Diagnostics.Debug.Assert(this.DataContext != null, "DataContext不能为空");
            this._mainWindowViewModel = (MainWindowViewModel) this.DataContext;
        }

        private void Button_OnClick(object? sender, RoutedEventArgs e)
        {
            _mainWindowViewModel.Greeting = "你好！";
        }
    }
}