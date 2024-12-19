
namespace MainApp.Models;

public class ActivityItem
{
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;

    public override string ToString()
    {
        return $"{Title} - {Description}";
    }
}
