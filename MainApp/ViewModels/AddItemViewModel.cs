using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MainApp.Models;
using Microsoft.Extensions.DependencyInjection;


namespace MainApp.ViewModels;

public partial class AddItemViewModel(IServiceProvider serviceProvider) : ObservableObject
{
    private IServiceProvider _serviceProvider = serviceProvider;

    [ObservableProperty]
    private string headline = "New Activity";

    [ObservableProperty]
    private string warningMessage = "";

    [ObservableProperty]
    private ActivityItem activityItem = new();

    [RelayCommand]
    public void Add()
    {
        if (!string.IsNullOrEmpty(ActivityItem.Title))
        {
            var newItem = new ActivityItem
            {
                Title = ActivityItem.Title,
                Description = ActivityItem.Description
            };

            WarningMessage = "";

            var mainViewModel = _serviceProvider.GetRequiredService<MainViewModel>();
            mainViewModel.CurrentViewModel = _serviceProvider.GetRequiredService<ListItemsViewModel>();
        }
        else
        {
            WarningMessage = "Please enter a title";
        }
    }

    [RelayCommand]
    public void Cancel()
    {
        var mainViewModel = _serviceProvider.GetRequiredService<MainViewModel>();
        mainViewModel.CurrentViewModel = _serviceProvider.GetRequiredService<GetStartedViewModel>();
    }
}
