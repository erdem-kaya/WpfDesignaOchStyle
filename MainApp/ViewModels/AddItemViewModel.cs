using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;


namespace MainApp.ViewModels;

public partial class AddItemViewModel(IServiceProvider serviceProvider) : ObservableObject
{
    private IServiceProvider _serviceProvider = serviceProvider;

    [ObservableProperty]
    private string headline = "New Activity";

    [ObservableProperty]
    private string warningMessage = "";

    //[ObservableProperty]
    //private ActivityItem activityItem = new();

    //[RelayCommand]
    //public void Add()
    //{
    //    if (!string.IsNullOrEmpty(activityItem.Title))
    //    {
    //        ActivityItem = new();
    //        WarningMessage = "";
    //        var mainViewModel = _serviceProvider.GetRequiredService<MainViewModel>();
    //        mainViewModel.CurrentViewModel = _serviceProvider.GetRequiredService<ListItemsViewModel>();
    //    }
    //    else
    //    {
    //        WarningMessage = "Please enter a title";
    //    }
    //}

    //[RelayCommand]
    //public void Cancel()
    //{
    //    var mainViewModel = _serviceProvider.GetRequiredService<MainViewModel>();
    //    mainViewModel.CurrentViewModel = _serviceProvider.GetRequiredService<GetStartedViewModel>();
    //}
}
