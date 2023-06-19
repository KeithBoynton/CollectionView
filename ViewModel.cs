using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MauiApp1
{
    public partial class ViewModel : ObservableObject
    {
        public ViewModel()
        {
            // Set up the items
            Items = new ObservableCollection<string> { "one", "two", "three", "four", "five" };

            // Here we try to preselect as per https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/collectionview/selection#multiple-preselection
            SelectedItems = new ObservableCollection<object>()
            {
                Items[1], Items[3]
            };
        }

        public ObservableCollection<string> Items { get; set; }

        public ObservableCollection<object> SelectedItems
        {
            get => selectedItems;
            set => SetProperty(ref selectedItems, value);
        }
        ObservableCollection<object> selectedItems;

        [RelayCommand]
        Task PreSelectUsingBinding()
        {
            SelectedItems = new ObservableCollection<object> { Items[1], Items[3] };

            return Task.CompletedTask;
        }

        public void PreSelectFromOnAppearing()
        {
            SelectedItems.Clear();
            SelectedItems.Add(Items[1]);
            SelectedItems.Add(Items[3]);
        }
    }
}
