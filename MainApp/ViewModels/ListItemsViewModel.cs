using CommunityToolkit.Mvvm.ComponentModel;

namespace MainApp.ViewModels;

public partial class ListItemsViewModel : ObservableObject
{
    [ObservableProperty]
    private string headline = "Your Activities";
}
