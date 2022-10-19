using System.Collections.ObjectModel;

namespace Avalonia.NETCoreApp1.ViewModels;

public class TreeViewModel : ViewModelBase
{
    private string _name;

    public string Name
    {
        get => _name;
        set => SetField(ref _name, value, nameof(Name));
    }

    private string _value = string.Empty;

    public string Value
    {
        get => _value;
        set => SetField(ref _value, value, nameof(Value));
    }

    public ObservableCollection<TreeViewModel> SubFolders { get; } = new ObservableCollection<TreeViewModel>();
}