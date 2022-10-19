using System.Collections.ObjectModel;
using Avalonia.Controls;
using Avalonia.NETCoreApp1.ViewModels;

namespace Avalonia.NETCoreApp1
{
    public partial class MainWindow : Window
    {
        private readonly MainViewModel _mainViewModel;

        public MainWindow()
        {
            InitializeComponent();
            _mainViewModel = (MainViewModel?)this.DataContext;

            _mainViewModel.TreeViewModels1.Add(new TreeViewModel()
            {
                Name = "item-1",
                Value = "value-1",
                SubFolders =
                {
                    new TreeViewModel()
                    {
                        Name = "item-1-1",
                        Value = "value-1-1"
                    }
                }
            });
            _mainViewModel.TreeViewModels1.Add(new TreeViewModel()
            {
                Name = "item-2",
                Value = "value-2",
                SubFolders =
                {
                    new TreeViewModel()
                    {
                        Name = "item-2-1",
                        Value = "value-2-1"
                    }
                }
            });

            _mainViewModel.TreeViewModels2.Add(new TreeViewModel()
            {
                Name = "item-1",
                Value = "value-1",
                SubFolders =
                {
                    new TreeViewModel()
                    {
                        Name = "item-1-1",
                        Value = "value-1-1"
                    }
                }
            });
            _mainViewModel.TreeViewModels2.Add(new TreeViewModel()
            {
                Name = "item-2",
                Value = "value-2",
                SubFolders =
                {
                    new TreeViewModel()
                    {
                        Name = "item-2-1",
                        Value = "value-2-1"
                    }
                }
            });
        }

        private int _count1 = 0;
        private int _count2 = 0;

        private void MyTreeView_OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
        {
            if (sender is TreeView treeView)
            {
                if (treeView.SelectedItem is TreeViewModel treeViewModel)
                {
                    treeViewModel.Value = $"count:{_count1++}";
                }
            }
        }

        private void MyListBox_OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
        {
            if (sender is ListBox listBox && listBox.SelectedItem is TreeViewModel treeViewModel)
            {
                treeViewModel.Value = $"count:{_count2++}";
            }
        }
    }
}