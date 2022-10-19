using System.Collections.ObjectModel;

namespace Avalonia.NETCoreApp1.ViewModels;

public class MainViewModel : ViewModelBase
{
    public ObservableCollection<TreeViewModel> TreeViewModels1 { get; } = new ObservableCollection<TreeViewModel>();
    public ObservableCollection<TreeViewModel> TreeViewModels2 { get; } = new ObservableCollection<TreeViewModel>();
}